using MyProject.DAL;
using MyProject.Models; // Models (Entities)

namespace MyProject.BLL
{
    public class MyBusinessLogic
    {
        private readonly MyDataAccess _dataAccess;

        public MyBusinessLogic()
        {
            _dataAccess = new MyDataAccess(); // Or use Dependency Injection
        }

        public IEnumerable<MyEntity> GetAllEntities()
        {
            try
            {
                return _dataAccess.GetAllEntities();
            }
            catch (Exception ex)
            {
                // Log exception
                throw new ApplicationException("An error occurred while fetching entities.", ex);
            }
        }

        public MyEntity GetEntityById(int id)
        {
            try
            {
                return _dataAccess.GetEntityById(id);
            }
            catch (Exception ex)
            {
                // Log exception
                throw new ApplicationException("An error occurred while fetching the entity.", ex);
            }
        }

        public void AddEntity(MyEntity entity)
        {
            try
            {
                // Business logic validation
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));
                
                _dataAccess.AddEntity(entity);
            }
            catch (Exception ex)
            {
                // Log exception
                throw new ApplicationException("An error occurred while adding the entity.", ex);
            }
        }

        public void UpdateEntity(MyEntity entity)
        {
            try
            {
                // Business logic validation
                if (entity == null)
                    throw new ArgumentNullException(nameof(entity));
                
                _dataAccess.UpdateEntity(entity);
            }
            catch (Exception ex)
            {
                // Log exception
                throw new ApplicationException("An error occurred while updating the entity.", ex);
            }
        }

        public void DeleteEntity(int id)
        {
            try
            {
                _dataAccess.DeleteEntity(id);
            }
            catch (Exception ex)
            {
                // Log exception
                throw new ApplicationException("An error occurred while deleting the entity.", ex);
            }
        }
    }
}