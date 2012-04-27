package jpetroules.cs290;

import android.app.Activity;
import android.os.Bundle;
import android.widget.TextView;

public class HalloUniversum extends Activity
{
	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		//setContentView(R.layout.main);
		TextView tv = new TextView(this);
		tv.setText("Hallo, Universum!");
		setContentView(tv);
	}
}
