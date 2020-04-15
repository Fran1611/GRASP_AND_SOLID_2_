//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public string FormatRecipeToPrint()
        {
            string recipe = ($"Receta de {this.FinalProduct.Description}:\n");
            foreach (Step step in this.steps)
            {
                recipe += ($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time} \n");
            }
            recipe += $"El costo de hacer {this.FinalProduct.Description} es de: {GetProductionCost()}\n";
            return recipe;
        }
        public double GetProductionCost()
        {   
        double costoFinal = 0;
            
            foreach(Step step in steps)
            {
                costoFinal += (step.Quantity/1000 * step.Input.UnitCost) + (step.Time/3600 * (step.Equipment.HourlyCost));
            }
            return costoFinal;
        }
    }
}