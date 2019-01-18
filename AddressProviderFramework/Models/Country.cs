namespace AddressProviderFramework.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class Country
    {
        public string Name { get; set; }
        private List<State> States { get; set; } = new List<State>();

        public State AddOrGetState(string stateName)
        {
            var registeredState = this.GetState(stateName);
            if (registeredState == null)
            {
                registeredState = new State
                {
                    Name = stateName,
                    Country = this
                };

                this.AddState(registeredState);
            }

            return registeredState;
        }

        public State GetState(string stateName)
        {
            return this.States.SingleOrDefault(s => s.Name == stateName);
        }

        public IEnumerable<State> GetStates()
        {
            return this.States;
        }

        private void AddState(State state)
        {
            this.States.Add(state);
        }
        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
