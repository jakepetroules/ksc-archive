package jpetroules.cs290;

import android.app.*;
import android.os.*;
import android.view.*;
import android.widget.*;
import android.widget.AdapterView.*;

public class jpetroulesComicalImages extends Activity
{
	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);

		GridView gridview = (GridView)findViewById(R.id.gridview);
		gridview.setAdapter(new ImageAdapter(this));

		gridview.setOnItemClickListener(new OnItemClickListener()
		{
			public void onItemClick(AdapterView<?> parent, View v, int position, long id)
			{
				Toast.makeText(jpetroulesComicalImages.this, "" + position, Toast.LENGTH_SHORT).show();
			}
		});
	}
}
