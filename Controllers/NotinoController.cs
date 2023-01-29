using Microsoft.AspNetCore.Mvc;
using NotinoAppka.Data;
using NotinoAppka.Models;

namespace NotinoAppka.Controllers
{


		[Route("api/[controller]/[action]")]
		[ApiController]
		public class NotinoController : ControllerBase
		{
			private readonly APIcontext _context;

			public NotinoController(APIcontext context)
			{
				_context = context;
			}

		// Create / Edit
		[HttpPut]
			public JsonResult CreateEdit(NotinoModel nData)
			{
				if (nData.Id == 0)
				{
					_context.NotinoData.Add(nData);
				}
				else
				{
					var dataInDb = _context.NotinoData.Find(nData.Id);

					if (dataInDb == null)
						return new JsonResult(NotFound());

					dataInDb = nData;

				}

				_context.SaveChanges();

				return new JsonResult(Ok(nData));
			}

			//Get
			[HttpGet]
			public JsonResult Get(int id)
			{
				var result = _context.NotinoData.Find(id);

				if (result == null)
					return new JsonResult(NotFound());

				return new JsonResult(Ok(result));

			}

			//Delete
			[HttpDelete]
			public JsonResult Delete(int id)
			{
				var result = _context.NotinoData.Find(id);

				if (result == null)
					return new JsonResult(NotFound());

				_context.NotinoData.Remove(result);
				_context.SaveChanges();

				return new JsonResult(NoContent());
			}

			//Get all
			[HttpGet()]
			public JsonResult GetAll()
			{
				var result = _context.NotinoData.ToList();

				return new JsonResult(Ok(result));

			}

		
	}
}
