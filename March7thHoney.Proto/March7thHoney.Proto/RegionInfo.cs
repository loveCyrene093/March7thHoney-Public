using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RegionInfo : IMessage<RegionInfo>, IMessage, IEquatable<RegionInfo>, IDeepCloneable<RegionInfo>, IBufferMessage
{
	private static readonly MessageParser<RegionInfo> _parser = new MessageParser<RegionInfo>(() => new RegionInfo());

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private string name_ = "";

	public const int TitleFieldNumber = 2;

	private string title_ = "";

	public const int DispatchUrlFieldNumber = 3;

	private string dispatchUrl_ = "";

	public const int EnvTypeFieldNumber = 4;

	private string envType_ = "";

	public const int DisplayNameFieldNumber = 5;

	private string displayName_ = "";

	public const int StopDescFieldNumber = 6;

	private string stopDesc_ = "";

	public const int MPDILONJDEHFieldNumber = 7;

	private string mPDILONJDEH_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RegionInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RegionInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Title
	{
		get
		{
			return title_;
		}
		set
		{
			title_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DispatchUrl
	{
		get
		{
			return dispatchUrl_;
		}
		set
		{
			dispatchUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string EnvType
	{
		get
		{
			return envType_;
		}
		set
		{
			envType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DisplayName
	{
		get
		{
			return displayName_;
		}
		set
		{
			displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string StopDesc
	{
		get
		{
			return stopDesc_;
		}
		set
		{
			stopDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MPDILONJDEH
	{
		get
		{
			return mPDILONJDEH_;
		}
		set
		{
			mPDILONJDEH_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RegionInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RegionInfo(RegionInfo other)
		: this()
	{
		name_ = other.name_;
		title_ = other.title_;
		dispatchUrl_ = other.dispatchUrl_;
		envType_ = other.envType_;
		displayName_ = other.displayName_;
		stopDesc_ = other.stopDesc_;
		mPDILONJDEH_ = other.mPDILONJDEH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RegionInfo Clone()
	{
		return new RegionInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RegionInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RegionInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (Title != other.Title)
		{
			return false;
		}
		if (DispatchUrl != other.DispatchUrl)
		{
			return false;
		}
		if (EnvType != other.EnvType)
		{
			return false;
		}
		if (DisplayName != other.DisplayName)
		{
			return false;
		}
		if (StopDesc != other.StopDesc)
		{
			return false;
		}
		if (MPDILONJDEH != other.MPDILONJDEH)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Title.Length != 0)
		{
			num ^= Title.GetHashCode();
		}
		if (DispatchUrl.Length != 0)
		{
			num ^= DispatchUrl.GetHashCode();
		}
		if (EnvType.Length != 0)
		{
			num ^= EnvType.GetHashCode();
		}
		if (DisplayName.Length != 0)
		{
			num ^= DisplayName.GetHashCode();
		}
		if (StopDesc.Length != 0)
		{
			num ^= StopDesc.GetHashCode();
		}
		if (MPDILONJDEH.Length != 0)
		{
			num ^= MPDILONJDEH.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Name.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Name);
		}
		if (Title.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Title);
		}
		if (DispatchUrl.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(DispatchUrl);
		}
		if (EnvType.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(EnvType);
		}
		if (DisplayName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(DisplayName);
		}
		if (StopDesc.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(StopDesc);
		}
		if (MPDILONJDEH.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(MPDILONJDEH);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Title.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Title);
		}
		if (DispatchUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DispatchUrl);
		}
		if (EnvType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EnvType);
		}
		if (DisplayName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
		}
		if (StopDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StopDesc);
		}
		if (MPDILONJDEH.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MPDILONJDEH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RegionInfo other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Title.Length != 0)
			{
				Title = other.Title;
			}
			if (other.DispatchUrl.Length != 0)
			{
				DispatchUrl = other.DispatchUrl;
			}
			if (other.EnvType.Length != 0)
			{
				EnvType = other.EnvType;
			}
			if (other.DisplayName.Length != 0)
			{
				DisplayName = other.DisplayName;
			}
			if (other.StopDesc.Length != 0)
			{
				StopDesc = other.StopDesc;
			}
			if (other.MPDILONJDEH.Length != 0)
			{
				MPDILONJDEH = other.MPDILONJDEH;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
				Name = input.ReadString();
				break;
			case 18u:
				Title = input.ReadString();
				break;
			case 26u:
				DispatchUrl = input.ReadString();
				break;
			case 34u:
				EnvType = input.ReadString();
				break;
			case 42u:
				DisplayName = input.ReadString();
				break;
			case 50u:
				StopDesc = input.ReadString();
				break;
			case 58u:
				MPDILONJDEH = input.ReadString();
				break;
			}
		}
	}
}
