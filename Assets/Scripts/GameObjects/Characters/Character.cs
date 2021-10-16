using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string FullName { get { return $"{this.LastName} {this.FirstName}"; } }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Gender { get; set; }

    public int Age { get; set; }
}
