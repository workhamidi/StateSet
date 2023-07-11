using Microsoft.AspNetCore.Mvc;
using StateSet.Bll.Classes.Dtos.Flow;
using StateSet.Bll.Classes.Enums;
using StateSet.Bll.Classes.Models.ResultObjects;
using StateSet.Bll.Common.GetMethodsName;
using StateSet.LogManager;

namespace StateSet.Ui.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlowController : ControllerBase
    {
        private readonly ILog _log;

        private string _className => GetType().na!;

        public FlowController(ILog log)
        {
            _log = log;
        }

        [HttpPost("CreateFlow")]
        public async Task<Resultaa> CreateFlow([FromBody] FlowDto flow)
        {
            try
            {
                _log.Information($"the create new the Flow request was received",
                    new List<KeyValuePair<object, object>>()
                    {
                        new ("class name",_className),
                        new ("method name",GetMethodName.GetName()),
                        new ("flow Name",flow.Name),
                        new ("Request ID",HttpContext.Items["RequestId"]!)
                    });


                _log.Information($"the create new the Flow request was processed",
                    new List<KeyValuePair<object, object>>()
                    {
                        new ("class name",_className),
                        new ("method name",GetMethodName.GetName()),
                        new ("flow Name",flow.Name),
                        new ("Request ID",HttpContext.Items["RequestId"]!)
                    });


                


            }
            catch (Exception exception)
            {
                _log.Error($"the the error has occurred in {GetMethodName.GetName()}",
                    new List<KeyValuePair<object, object>>()
                    {
                        new ("class name",_className),
                        new ("method name",GetMethodName.GetName()),
                        new ("flow Name",flow.Name),
                        new ("Request ID",HttpContext.Items["RequestId"]!)
                    }, exception);


                //return Task.FromResult(new Resultaa()
                //{
                //    Descriptions = "Asdv",
                //    ResultStatus = ResultStatusEnum.Exception
                //});

                return Task.

            }
        }
    }
}