using StateSet.Bll.Classes.Enums;

namespace StateSet.Bll.Classes.Models.ResultObjects
{
    public class Resultaa
    {
        public ResultStatusEnum ResultStatus { get; set; } = ResultStatusEnum.None;

        public string Descriptions { get; set; } = string.Empty;
    }
}
