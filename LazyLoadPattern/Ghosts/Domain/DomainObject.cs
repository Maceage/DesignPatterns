using System.Collections;

namespace LazyLoadPattern.Ghosts.Domain
{
    public abstract class DomainObject
    {
	    private LoadStatus _status;

	    protected DomainObject(int id)
        {
            Id = id;
        }

	    public int Id { get; set; }

	    public bool IsGhost
        {
            get { return _status == LoadStatus.Ghost; }
        }

        public bool IsLoaded
        {
            get { return _status == LoadStatus.Loaded; }
        }

        public void MarkLoading()
        {
            _status = LoadStatus.Loading;
        }

        public void MarkLoaded()
        {
            _status = LoadStatus.Loaded;
        }

        public virtual void Load()
        {
	        if (!IsGhost)
	        {
		        return;
	        }

            var dataRow = GetDataRow();
            LoadLine(dataRow);
        }

        private void LoadLine(ArrayList dataRow)
        {
	        if (IsGhost)
	        {
				MarkLoading();
				DoLoadLine(dataRow);
				MarkLoaded();
			}
        }

        protected abstract void DoLoadLine(ArrayList dataRow);
        protected abstract ArrayList GetDataRow();
    }
}