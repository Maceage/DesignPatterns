using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FactoryPattern.Domain;

namespace FactoryPattern.Factory
{
    public class SmurfFactory
    {
        private Dictionary<string, Type> _smurfs;

        public SmurfFactory()
        {
            LoadTypes();
        }

        public ISmurf CreateInstance(string carName)
        {
            Type t = GetTypeToCreate(carName);

            if (t == null)
            {
                return new NullSmurf();
            }

            return Activator.CreateInstance(t) as ISmurf;
        }

        private Type GetTypeToCreate(string smurfName)
        {
            return (from smurf in _smurfs where smurf.Key.Contains(smurfName) select _smurfs[smurf.Key]).FirstOrDefault();
        }

        private void LoadTypes()
        {
            _smurfs = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(ISmurf).ToString()) != null)
                {
                    _smurfs.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}