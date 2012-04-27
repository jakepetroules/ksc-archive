package jpetroules.cs290;

import android.app.*;
import android.os.*;
import android.widget.*;
import android.widget.AdapterView.*;
import android.view.*;

public class jpetroulesMetalsList extends ListActivity
{
	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		setListAdapter(new ArrayAdapter<String>(this, R.layout.list_item, METALS));

		ListView lv = getListView();
		lv.setTextFilterEnabled(true);

		lv.setOnItemClickListener(new OnItemClickListener()
		{
			public void onItemClick(AdapterView<?> parent, View view, int position, long id)
			{
				// When clicked, show a toast with the TextView text
				Toast.makeText(getApplicationContext(), ((TextView)view).getText(), Toast.LENGTH_SHORT).show();
			}
		});
	}

	static final String[] METALS = new String[] { "Aluminum", "Brass", "Bronze", "Copper", "Gold", "Iron", "Platinum", "Silver", "Steel", "Tin", "Titanium", "Vanadium", "Zinc" };
}
