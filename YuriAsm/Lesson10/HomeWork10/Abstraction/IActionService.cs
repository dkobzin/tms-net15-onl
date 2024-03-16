using HomeWork10.Data.Services.Base;

namespace HomeWork10.Abstraction
{
    public interface IActionService
    {
        public ActionResult AddServiceCount(Guid id, int count);
        public ActionResult SubtractServiceCount(Guid id, int count);
        public ActionResult RemoveService(Guid id);

        public ActionResult AddService(Service service);
    }
}
