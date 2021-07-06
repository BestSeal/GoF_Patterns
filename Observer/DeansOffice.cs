namespace Observer
{
    public class DeansOffice : IObservable, IObserver
    {
        private DB _db;
        private Department _department;

        public void Register(IObserver o)
        {
            if (o is Department department)
            {
                _department = department;
            }
        }

        public void Remove(IObserver o)
        {
            _department = null;
        }

        public void Notify()
        {
            _department?.Receive(this);
        }

        public void Receive(object sender)
        {
            if (sender is Scheduler)
            {
                foreach (var lecturer in _department.Lecturers)
                {
                    var report = _db.Reports.Find(x => x.Lecturer == lecturer);
                    if (report == null)
                    {
                        _department.Receive(lecturer);
                    }
                    else
                    {
                        _db.Reports.Remove(report);
                    }
                }
            }
        }

        public DeansOffice(DB db)
        {
            _db = db;
        }
    }
}