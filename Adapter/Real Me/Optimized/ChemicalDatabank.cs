using System;

namespace Optimized
{
    public class ChemicalDatabank
    {
        // The databank 'legacy API'
        public float GetCriticalPoint(Chemical compound, State point)
        {
            if (point == State.Melting)
            {
                switch (compound)
                {
                    case Chemical.Water:
                        return 0.0f;
                    case Chemical.Benzene:
                        return 5.5f;
                    case Chemical.Ethanol:
                        return -114.1f;
                    default:
                        return 0f;
                }
            }
            else if (point == State.Boiling)
            {
                switch (compound)
                {
                    case Chemical.Water:
                        return 100.0f;
                    case Chemical.Benzene:
                        return 80.1f;
                    case Chemical.Ethanol:
                        return 78.3f;
                    default:
                        return 0f;
                }
            }
            return 0f;
        }

        public string GetMolecularStructure(Chemical compound)
        {
            switch (compound)
            {
                case Chemical.Water:
                    return "H2O";
                case Chemical.Benzene:
                    return "C6H6";
                case Chemical.Ethanol:
                    return "C2H5OH";
                default:
                    return "";
            }
        }

        public double GetMolecularWeight(Chemical compound)
        {
            switch (compound)
            {
                case Chemical.Water:
                    return 18.015d;
                case Chemical.Benzene:
                    return 78.1134d;
                case Chemical.Ethanol:
                    return 46.0688d;
                default:
                    return 0d;
            }
        }
    }
}
