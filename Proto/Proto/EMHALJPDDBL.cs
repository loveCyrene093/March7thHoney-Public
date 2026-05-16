using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EMHALJPDDBL : IMessage<EMHALJPDDBL>, IMessage, IEquatable<EMHALJPDDBL>, IDeepCloneable<EMHALJPDDBL>, IBufferMessage
{
	private static readonly MessageParser<EMHALJPDDBL> _parser = new MessageParser<EMHALJPDDBL>(() => new EMHALJPDDBL());

	private UnknownFieldSet _unknownFields;

	public const int HNFNOKILNFEFieldNumber = 4;

	private bool hNFNOKILNFE_;

	public const int DOHLLMLDLMPFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_dOHLLMLDLMP_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> dOHLLMLDLMP_ = new RepeatedField<uint>();

	public const int LBPLNLDHCBOFieldNumber = 9;

	private bool lBPLNLDHCBO_;

	public const int GPJHJOOIJJCFieldNumber = 12;

	private uint gPJHJOOIJJC_;

	public const int GIAOIMOFALHFieldNumber = 13;

	private ulong gIAOIMOFALH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EMHALJPDDBL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EMHALJPDDBLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HNFNOKILNFE
	{
		get
		{
			return hNFNOKILNFE_;
		}
		set
		{
			hNFNOKILNFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DOHLLMLDLMP => dOHLLMLDLMP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LBPLNLDHCBO
	{
		get
		{
			return lBPLNLDHCBO_;
		}
		set
		{
			lBPLNLDHCBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GPJHJOOIJJC
	{
		get
		{
			return gPJHJOOIJJC_;
		}
		set
		{
			gPJHJOOIJJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong GIAOIMOFALH
	{
		get
		{
			return gIAOIMOFALH_;
		}
		set
		{
			gIAOIMOFALH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMHALJPDDBL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMHALJPDDBL(EMHALJPDDBL other)
		: this()
	{
		hNFNOKILNFE_ = other.hNFNOKILNFE_;
		dOHLLMLDLMP_ = other.dOHLLMLDLMP_.Clone();
		lBPLNLDHCBO_ = other.lBPLNLDHCBO_;
		gPJHJOOIJJC_ = other.gPJHJOOIJJC_;
		gIAOIMOFALH_ = other.gIAOIMOFALH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMHALJPDDBL Clone()
	{
		return new EMHALJPDDBL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EMHALJPDDBL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EMHALJPDDBL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HNFNOKILNFE != other.HNFNOKILNFE)
		{
			return false;
		}
		if (!dOHLLMLDLMP_.Equals(other.dOHLLMLDLMP_))
		{
			return false;
		}
		if (LBPLNLDHCBO != other.LBPLNLDHCBO)
		{
			return false;
		}
		if (GPJHJOOIJJC != other.GPJHJOOIJJC)
		{
			return false;
		}
		if (GIAOIMOFALH != other.GIAOIMOFALH)
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
		if (HNFNOKILNFE)
		{
			num ^= HNFNOKILNFE.GetHashCode();
		}
		num ^= dOHLLMLDLMP_.GetHashCode();
		if (LBPLNLDHCBO)
		{
			num ^= LBPLNLDHCBO.GetHashCode();
		}
		if (GPJHJOOIJJC != 0)
		{
			num ^= GPJHJOOIJJC.GetHashCode();
		}
		if (GIAOIMOFALH != 0L)
		{
			num ^= GIAOIMOFALH.GetHashCode();
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
		if (HNFNOKILNFE)
		{
			output.WriteRawTag(32);
			output.WriteBool(HNFNOKILNFE);
		}
		dOHLLMLDLMP_.WriteTo(ref output, _repeated_dOHLLMLDLMP_codec);
		if (LBPLNLDHCBO)
		{
			output.WriteRawTag(72);
			output.WriteBool(LBPLNLDHCBO);
		}
		if (GPJHJOOIJJC != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(GPJHJOOIJJC);
		}
		if (GIAOIMOFALH != 0L)
		{
			output.WriteRawTag(104);
			output.WriteUInt64(GIAOIMOFALH);
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
		if (HNFNOKILNFE)
		{
			num += 2;
		}
		num += dOHLLMLDLMP_.CalculateSize(_repeated_dOHLLMLDLMP_codec);
		if (LBPLNLDHCBO)
		{
			num += 2;
		}
		if (GPJHJOOIJJC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPJHJOOIJJC);
		}
		if (GIAOIMOFALH != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(GIAOIMOFALH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EMHALJPDDBL other)
	{
		if (other != null)
		{
			if (other.HNFNOKILNFE)
			{
				HNFNOKILNFE = other.HNFNOKILNFE;
			}
			dOHLLMLDLMP_.Add(other.dOHLLMLDLMP_);
			if (other.LBPLNLDHCBO)
			{
				LBPLNLDHCBO = other.LBPLNLDHCBO;
			}
			if (other.GPJHJOOIJJC != 0)
			{
				GPJHJOOIJJC = other.GPJHJOOIJJC;
			}
			if (other.GIAOIMOFALH != 0L)
			{
				GIAOIMOFALH = other.GIAOIMOFALH;
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
			case 32u:
				HNFNOKILNFE = input.ReadBool();
				break;
			case 56u:
			case 58u:
				dOHLLMLDLMP_.AddEntriesFrom(ref input, _repeated_dOHLLMLDLMP_codec);
				break;
			case 72u:
				LBPLNLDHCBO = input.ReadBool();
				break;
			case 96u:
				GPJHJOOIJJC = input.ReadUInt32();
				break;
			case 104u:
				GIAOIMOFALH = input.ReadUInt64();
				break;
			}
		}
	}
}
