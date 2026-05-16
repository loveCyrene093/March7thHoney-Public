using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GDIECABCIGN : IMessage<GDIECABCIGN>, IMessage, IEquatable<GDIECABCIGN>, IDeepCloneable<GDIECABCIGN>, IBufferMessage
{
	private static readonly MessageParser<GDIECABCIGN> _parser = new MessageParser<GDIECABCIGN>(() => new GDIECABCIGN());

	private UnknownFieldSet _unknownFields;

	public const int JOBOBJLDCAJFieldNumber = 2;

	private uint jOBOBJLDCAJ_;

	public const int LGMKFBIINGKFieldNumber = 7;

	private uint lGMKFBIINGK_;

	public const int OEMMDHMBDPAFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_oEMMDHMBDPA_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> oEMMDHMBDPA_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GDIECABCIGN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GDIECABCIGNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JOBOBJLDCAJ
	{
		get
		{
			return jOBOBJLDCAJ_;
		}
		set
		{
			jOBOBJLDCAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LGMKFBIINGK
	{
		get
		{
			return lGMKFBIINGK_;
		}
		set
		{
			lGMKFBIINGK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OEMMDHMBDPA => oEMMDHMBDPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDIECABCIGN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDIECABCIGN(GDIECABCIGN other)
		: this()
	{
		jOBOBJLDCAJ_ = other.jOBOBJLDCAJ_;
		lGMKFBIINGK_ = other.lGMKFBIINGK_;
		oEMMDHMBDPA_ = other.oEMMDHMBDPA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDIECABCIGN Clone()
	{
		return new GDIECABCIGN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GDIECABCIGN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GDIECABCIGN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JOBOBJLDCAJ != other.JOBOBJLDCAJ)
		{
			return false;
		}
		if (LGMKFBIINGK != other.LGMKFBIINGK)
		{
			return false;
		}
		if (!oEMMDHMBDPA_.Equals(other.oEMMDHMBDPA_))
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
		if (JOBOBJLDCAJ != 0)
		{
			num ^= JOBOBJLDCAJ.GetHashCode();
		}
		if (LGMKFBIINGK != 0)
		{
			num ^= LGMKFBIINGK.GetHashCode();
		}
		num ^= oEMMDHMBDPA_.GetHashCode();
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
		if (JOBOBJLDCAJ != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JOBOBJLDCAJ);
		}
		if (LGMKFBIINGK != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(LGMKFBIINGK);
		}
		oEMMDHMBDPA_.WriteTo(ref output, _repeated_oEMMDHMBDPA_codec);
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
		if (JOBOBJLDCAJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JOBOBJLDCAJ);
		}
		if (LGMKFBIINGK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LGMKFBIINGK);
		}
		num += oEMMDHMBDPA_.CalculateSize(_repeated_oEMMDHMBDPA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GDIECABCIGN other)
	{
		if (other != null)
		{
			if (other.JOBOBJLDCAJ != 0)
			{
				JOBOBJLDCAJ = other.JOBOBJLDCAJ;
			}
			if (other.LGMKFBIINGK != 0)
			{
				LGMKFBIINGK = other.LGMKFBIINGK;
			}
			oEMMDHMBDPA_.Add(other.oEMMDHMBDPA_);
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
			case 16u:
				JOBOBJLDCAJ = input.ReadUInt32();
				break;
			case 56u:
				LGMKFBIINGK = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				oEMMDHMBDPA_.AddEntriesFrom(ref input, _repeated_oEMMDHMBDPA_codec);
				break;
			}
		}
	}
}
