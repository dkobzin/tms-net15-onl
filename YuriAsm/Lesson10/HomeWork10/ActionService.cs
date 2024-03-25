using HomeWork10.Abstraction;
using HomeWork10.Data.Services.Base;

namespace HomeWork10
{
    public class ActionService : IActionService
    { 
        private readonly IInventory inventory;
        public ActionService(IInventory inventory)
        {
            this.inventory = inventory;
        }

        public ActionResult AddService(Service service)
        {
           
            if (service == null)
                throw new ArgumentNullException(nameof(service));

            var currentService = inventory.Services.FirstOrDefault(x => x.Name == service.Name);

            if (currentService != null)
                return ActionResult.Failed("Товар с таким наименованием уже существует");

            inventory.AddService(service);

            return ActionResult.Completed();
        }

        public ActionResult AddServiceCount(Guid id, int count)
        {
            if (id == default)
                throw new ArgumentNullException(nameof(id));

            var currentService = inventory.Services.FirstOrDefault(x => x.Id == id);

            if (currentService == null)
                return ActionResult.Failed("Товар с таким ID не найден");

            currentService.Supplement(count);

            return ActionResult.Completed();
        }

        public ActionResult RemoveService(Guid id)
        {
           
            if (id == default)
                throw new ArgumentNullException(nameof(id));

            var currentService = inventory.Services.FirstOrDefault(x => x.Id == id);

            if (currentService == null)
                return ActionResult.Failed("Товар с таким ID не найден");

            inventory.DeleteService(currentService);

            return ActionResult.Completed();
        }

        public ActionResult SubtractServiceCount(Guid id, int count)
        {
            if (id == default)
                throw new ArgumentNullException(nameof(id));

            var currentService = inventory.Services.FirstOrDefault(x => x.Id == id);

            if (currentService == null)
                return ActionResult.Failed("Товар с таким ID не найден");

            currentService.Subtract(count);

            return ActionResult.Completed();
        }
    }
}
