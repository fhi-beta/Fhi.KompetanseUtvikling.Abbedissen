using AutoMapper;
using Fhi.Abbedissen.Felles;
using Fhi.Abbedissen.KompetanseAPI.Controllers;
using Fhi.Abbedissen.KompetanseAPI.Model;
using Fhi.Abbedissen.KompetanseAPI.Profile;
using Fhi.Abbedissen.KompetanseAPI.Services;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Fhi.Abbedissen.KompetanseAPI.Test
{
    [TestFixture]
    public class KompetanseKontrollerTest
    {
        private KompetanseController controller;
        private IKompetanseService service;
        private IMapper mapper; 

        [SetUp]
        public void Setup()
        {
            service = Substitute.For<IKompetanseService>();
            mapper = new MapperConfiguration(mc => { mc.AddProfile(new KompetanseProfile()); }).CreateMapper();
            controller = new KompetanseController(service, mapper);
        }

        [Test]
        public void GetKompetanseListeTest()
        {
            // arrange
            var kompetanseList = new List<Kompetanse> {
                new Kompetanse { Id = 1, Navn = "React", Beskrivelse = "frontend" },
                new Kompetanse { Id = 2, Navn = "AutoMapper", Beskrivelse = "model mapper" }
            };

            // mock
            service.HentKompetanse().Returns(kompetanseList);

            // act
            var response = controller.GetKompetanse();

            // assert
            service.Received().HentKompetanse();
            Assert.IsInstanceOf<ActionResult<IEnumerable<KompetanseDTO>>>(response);
            Assert.IsInstanceOf<OkObjectResult>(response.Result);

            var listeAvKompetanseDto = (IEnumerable<KompetanseDTO>)((OkObjectResult)response.Result).Value;
            Assert.AreEqual(2, listeAvKompetanseDto.Count()); 
        }

        [Test]
        public void GetKompetanseByGuidTest()
        {
            // arrange            
            var kompetanse = new Kompetanse { Navn = "React", Beskrivelse = "beskrivelse av react" };

            // mock
            service.HentKompetanse(kompetanse.Guid).Returns(kompetanse);

            // act
            var response = controller.GetByGuid(kompetanse.Guid);
            
            // assert
            service.Received().HentKompetanse(kompetanse.Guid);
            Assert.IsInstanceOf<ActionResult<KompetanseDTO>>(response);

            var kompetanseDto = (KompetanseDTO)((OkObjectResult)response.Result).Value;
            Assert.AreEqual(kompetanse.Guid, kompetanseDto.Guid);
            Assert.AreEqual(kompetanse.Navn, kompetanseDto.Navn);
            Assert.AreEqual(kompetanse.Beskrivelse, kompetanseDto.Beskrivelse);
        }
    }
}