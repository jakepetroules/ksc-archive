package jpetroules.cs290;

import android.content.*;
import android.view.*;
import android.widget.*;

public class ImageAdapter extends BaseAdapter
{
	private Context mContext;

	public ImageAdapter(Context c)
	{
		mContext = c;
	}

	public int getCount()
	{
		return mThumbIds.length;
	}

	public Object getItem(int position)
	{
		return null;
	}

	public long getItemId(int position)
	{
		return 0;
	}

	// create a new ImageView for each item referenced by the Adapter
	public View getView(int position, View convertView, ViewGroup parent)
	{
		ImageView imageView;
		if (convertView == null)
		{
			// if it's not recycled, initialize some attributes
			imageView = new ImageView(mContext);
			imageView.setLayoutParams(new GridView.LayoutParams(85, 85));
			imageView.setScaleType(ImageView.ScaleType.CENTER_CROP);
			imageView.setPadding(8, 8, 8, 8);
		}
		else
		{
			imageView = (ImageView)convertView;
		}

		imageView.setImageResource(mThumbIds[position]);
		return imageView;
	}

	// references to our images
	private Integer[] mThumbIds =
	{
		R.drawable.captain_obvious,
		R.drawable.handegg,
		R.drawable.pointerstopointers,
		R.drawable.quantum_junction,
		R.drawable.regex,
		R.drawable.well_well_well
	};
}
