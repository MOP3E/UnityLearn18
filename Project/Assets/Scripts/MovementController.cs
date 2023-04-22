using System.Collections;
using System.Collections.Generic;
using SpaceShooter.UserControl;
using UnityEngine;

namespace SpaceShooter
{
    public class MovementController : Entity
    {
        /// <summary>
        /// Ось линейного ускорения.
        /// </summary>
        [SerializeField] private ControlAxis _accelerationAxis;

        /// <summary>
        /// Ось линейного ускорения.
        /// </summary>
        public ControlAxis AccelerationAxis => _accelerationAxis;

        /// <summary>
        /// Ось углового ускорения.
        /// </summary>
        [SerializeField] private ControlAxis _angularAccelerationAxis;

        /// <summary>
        /// Кнопка стрельбы из основного оружия.
        /// </summary>
        public ControlAxis AngularAccelerationAxis => _angularAccelerationAxis;

        /// <summary>
        /// Кнопка стрельбы из основного оружия.
        /// </summary>
        [SerializeField] private ControlAxis _primaryFireButton;

        /// <summary>
        /// Кнопка стрельбы из основного оружия.
        /// </summary>
        public ControlAxis PrimaryFireButton => _primaryFireButton;

        /// <summary>
        /// Кнопка стрельбы из вторичного оружия.
        /// </summary>
        [SerializeField] private ControlAxis _secondaryFireButton;

        /// <summary>
        /// Кнопка стрельбы из вторичного оружия.
        /// </summary>
        public ControlAxis SecondaryFireButton => _secondaryFireButton;
    }
}
