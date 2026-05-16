using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FloorCustomValueSnapshot : IMessage<FloorCustomValueSnapshot>, IMessage, IEquatable<FloorCustomValueSnapshot>, IDeepCloneable<FloorCustomValueSnapshot>, IBufferMessage
{
	private static readonly MessageParser<FloorCustomValueSnapshot> _parser = new MessageParser<FloorCustomValueSnapshot>(() => new FloorCustomValueSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int NameFieldNumber = 1;

	private string name_ = "";

	public const int TypeFieldNumber = 2;

	private BLLDKABGKLF type_;

	public const int BoolValFieldNumber = 3;

	private bool boolVal_;

	public const int FloatValFieldNumber = 4;

	private float floatVal_;

	public const int StrValFieldNumber = 5;

	private string strVal_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FloorCustomValueSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FloorCustomValueSnapshotReflection.Descriptor.MessageTypes[0];

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
	public BLLDKABGKLF Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BoolVal
	{
		get
		{
			return boolVal_;
		}
		set
		{
			boolVal_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float FloatVal
	{
		get
		{
			return floatVal_;
		}
		set
		{
			floatVal_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string StrVal
	{
		get
		{
			return strVal_;
		}
		set
		{
			strVal_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FloorCustomValueSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FloorCustomValueSnapshot(FloorCustomValueSnapshot other)
		: this()
	{
		name_ = other.name_;
		type_ = other.type_;
		boolVal_ = other.boolVal_;
		floatVal_ = other.floatVal_;
		strVal_ = other.strVal_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FloorCustomValueSnapshot Clone()
	{
		return new FloorCustomValueSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FloorCustomValueSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FloorCustomValueSnapshot other)
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
		if (Type != other.Type)
		{
			return false;
		}
		if (BoolVal != other.BoolVal)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FloatVal, other.FloatVal))
		{
			return false;
		}
		if (StrVal != other.StrVal)
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
		if (Type != BLLDKABGKLF.Pleacpiidin)
		{
			num ^= Type.GetHashCode();
		}
		if (BoolVal)
		{
			num ^= BoolVal.GetHashCode();
		}
		if (FloatVal != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FloatVal);
		}
		if (StrVal.Length != 0)
		{
			num ^= StrVal.GetHashCode();
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
		if (Type != BLLDKABGKLF.Pleacpiidin)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Type);
		}
		if (BoolVal)
		{
			output.WriteRawTag(24);
			output.WriteBool(BoolVal);
		}
		if (FloatVal != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(FloatVal);
		}
		if (StrVal.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(StrVal);
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
		if (Type != BLLDKABGKLF.Pleacpiidin)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (BoolVal)
		{
			num += 2;
		}
		if (FloatVal != 0f)
		{
			num += 5;
		}
		if (StrVal.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StrVal);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FloorCustomValueSnapshot other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Type != BLLDKABGKLF.Pleacpiidin)
			{
				Type = other.Type;
			}
			if (other.BoolVal)
			{
				BoolVal = other.BoolVal;
			}
			if (other.FloatVal != 0f)
			{
				FloatVal = other.FloatVal;
			}
			if (other.StrVal.Length != 0)
			{
				StrVal = other.StrVal;
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
			case 16u:
				Type = (BLLDKABGKLF)input.ReadEnum();
				break;
			case 24u:
				BoolVal = input.ReadBool();
				break;
			case 37u:
				FloatVal = input.ReadFloat();
				break;
			case 42u:
				StrVal = input.ReadString();
				break;
			}
		}
	}
}
