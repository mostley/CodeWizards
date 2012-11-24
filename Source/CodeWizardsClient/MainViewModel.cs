namespace CodeWizards.Client
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    using CodeWizards.Client.Annotations;
    using CodeWizards.Contracts;

    public class MainViewModel : INotifyPropertyChanged
    {
        private bool isLoggedIn;

        private Client client;

        private WorldData worldData;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<SpellInstance> Spells { get; set; }

        public ObservableCollection<WizardInfo> Wizards { get; set; }

        public bool IsLoggedIn
        {
            get
            {
                return isLoggedIn;
            }
            set
            {
                if (isLoggedIn != value)
                {
                    isLoggedIn = value;
                    this.OnPropertyChanged("IsLoggedIn");
                }
            }
        }

        public WorldData WorldData
        {
            get
            {
                return worldData;
            }
            set
            {
                if (worldData != value)
                {
                    worldData = value;
                    this.OnPropertyChanged("WorldData");
                }
            }
        }

        public MainViewModel()
        {
        }

        public void Join(string username)
        {
            this.client = new Client(username);
            this.client.Update += OnWorldUpdate;
        }

        private void OnWorldUpdate(WorldUpdate worldUpdate)
        {
            //TODO update WorldData
            if (WorldData == null)
            {
                WorldData = new WorldData(worldUpdate);
            }
            else
            {
                WorldData.Update(worldUpdate);
                this.OnPropertyChanged("WorldData");
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class WorldData : INotifyPropertyChanged
    {
        public List<List<GroundType>> Ground { get; set; }
        public List<Entity> Entities { get; set; }

        public WorldData(WorldUpdate worldUpdate)
        {
            Entities = new List<Entity>();
            Ground = new List<List<GroundType>>();
            InitGround(40, 40);

            this.Update(worldUpdate);
        }

        private void InitGround(int width, int height)
        {
            for (int y = 0; y < height; y++)
            {
                Ground.Add(new List<GroundType>());
                for (int x = 0; x < width; x++)
                {
                    Ground[y].Add(GroundType.Gras);
                }
            }
        }

        public void Update(WorldUpdate worldUpdate)
        {
            Entities = worldUpdate.LastDelvedEntities;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public enum GroundType
    {
        Gras
    }
}
