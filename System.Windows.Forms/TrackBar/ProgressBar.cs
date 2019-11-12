
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Gammasoft {
  //
  // Summary:
  //     Represents a Windows progress bar control.
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  [ComVisible(true)]
  [DefaultBindingProperty("Value")]
  [DefaultProperty("Value")]
  public class ProgressBar : System.Windows.Forms.ProgressBar {
    //
    // Summary:
    //     Gets or sets a value indicating the horizontal or vertical orientation of the progress bar.
    //
    // Returns:
    //     One of the System.Windows.Forms.Orientation values.
    //
    // Exceptions:
    //   T:System.ComponentModel.InvalidEnumArgumentException:
    //     The assigned value is not one of the System.Windows.Forms.Orientation values.
    [DefaultValue(Orientation.Horizontal)]
    [Localizable(true)]
    public Orientation Orientation {
      get { return orientation; }
      set {
        if (value != Orientation.Horizontal && value != Orientation.Vertical) throw new InvalidEnumArgumentException(string.Format("The value of argument 'value' ({0}) is invalid for Enum type 'Orientation'.", value));
        if (orientation != value) {
          orientation = value;
          if (IsHandleCreated) RecreateHandle();
        }
      }
    }

    //
    // Summary:
    //     Overrides System.Windows.Forms.Control.CreateParams.
    //
    // Returns:
    //     Information needed when you create a control.
    protected override CreateParams CreateParams {
      get {
        CreateParams createParams = base.CreateParams;
        if (Orientation == Orientation.Vertical) createParams.Style |= PBS_VERTICAL;
        return createParams;
      }
    }

    private Orientation orientation = Orientation.Horizontal;
    private const int PBS_VERTICAL = 4;
  }
}
