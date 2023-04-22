using System.Collections;
using System.Collections.Generic;
using SpaceShooter.UserControl;
using UnityEngine;

namespace SpaceShooter
{
    public class MovementController : Entity
    {
        /// <summary>
        /// ��� ��������� ���������.
        /// </summary>
        [SerializeField] private ControlAxis _accelerationAxis;

        /// <summary>
        /// ��� ��������� ���������.
        /// </summary>
        public ControlAxis AccelerationAxis => _accelerationAxis;

        /// <summary>
        /// ��� �������� ���������.
        /// </summary>
        [SerializeField] private ControlAxis _angularAccelerationAxis;

        /// <summary>
        /// ������ �������� �� ��������� ������.
        /// </summary>
        public ControlAxis AngularAccelerationAxis => _angularAccelerationAxis;

        /// <summary>
        /// ������ �������� �� ��������� ������.
        /// </summary>
        [SerializeField] private ControlAxis _primaryFireButton;

        /// <summary>
        /// ������ �������� �� ��������� ������.
        /// </summary>
        public ControlAxis PrimaryFireButton => _primaryFireButton;

        /// <summary>
        /// ������ �������� �� ���������� ������.
        /// </summary>
        [SerializeField] private ControlAxis _secondaryFireButton;

        /// <summary>
        /// ������ �������� �� ���������� ������.
        /// </summary>
        public ControlAxis SecondaryFireButton => _secondaryFireButton;
    }
}
