using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GLENEKHDKLJ : IMessage<GLENEKHDKLJ>, IMessage, IEquatable<GLENEKHDKLJ>, IDeepCloneable<GLENEKHDKLJ>, IBufferMessage
{
	private static readonly MessageParser<GLENEKHDKLJ> _parser = new MessageParser<GLENEKHDKLJ>(() => new GLENEKHDKLJ());

	private UnknownFieldSet _unknownFields;

	public const int NAPGANOLBGLFieldNumber = 5;

	private static readonly FieldCodec<CLJDMLFMFHA> _repeated_nAPGANOLBGL_codec = FieldCodec.ForMessage(42u, CLJDMLFMFHA.Parser);

	private readonly RepeatedField<CLJDMLFMFHA> nAPGANOLBGL_ = new RepeatedField<CLJDMLFMFHA>();

	public const int OPLBOCPIIBPFieldNumber = 8;

	private uint oPLBOCPIIBP_;

	public const int MGPJLHCHAMEFieldNumber = 9;

	private uint mGPJLHCHAME_;

	public const int AMHDFMFILBDFieldNumber = 10;

	private uint aMHDFMFILBD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GLENEKHDKLJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GLENEKHDKLJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CLJDMLFMFHA> NAPGANOLBGL => nAPGANOLBGL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OPLBOCPIIBP
	{
		get
		{
			return oPLBOCPIIBP_;
		}
		set
		{
			oPLBOCPIIBP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGPJLHCHAME
	{
		get
		{
			return mGPJLHCHAME_;
		}
		set
		{
			mGPJLHCHAME_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AMHDFMFILBD
	{
		get
		{
			return aMHDFMFILBD_;
		}
		set
		{
			aMHDFMFILBD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLENEKHDKLJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLENEKHDKLJ(GLENEKHDKLJ other)
		: this()
	{
		nAPGANOLBGL_ = other.nAPGANOLBGL_.Clone();
		oPLBOCPIIBP_ = other.oPLBOCPIIBP_;
		mGPJLHCHAME_ = other.mGPJLHCHAME_;
		aMHDFMFILBD_ = other.aMHDFMFILBD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLENEKHDKLJ Clone()
	{
		return new GLENEKHDKLJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GLENEKHDKLJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GLENEKHDKLJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nAPGANOLBGL_.Equals(other.nAPGANOLBGL_))
		{
			return false;
		}
		if (OPLBOCPIIBP != other.OPLBOCPIIBP)
		{
			return false;
		}
		if (MGPJLHCHAME != other.MGPJLHCHAME)
		{
			return false;
		}
		if (AMHDFMFILBD != other.AMHDFMFILBD)
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
		num ^= nAPGANOLBGL_.GetHashCode();
		if (OPLBOCPIIBP != 0)
		{
			num ^= OPLBOCPIIBP.GetHashCode();
		}
		if (MGPJLHCHAME != 0)
		{
			num ^= MGPJLHCHAME.GetHashCode();
		}
		if (AMHDFMFILBD != 0)
		{
			num ^= AMHDFMFILBD.GetHashCode();
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
		nAPGANOLBGL_.WriteTo(ref output, _repeated_nAPGANOLBGL_codec);
		if (OPLBOCPIIBP != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(OPLBOCPIIBP);
		}
		if (MGPJLHCHAME != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(MGPJLHCHAME);
		}
		if (AMHDFMFILBD != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AMHDFMFILBD);
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
		num += nAPGANOLBGL_.CalculateSize(_repeated_nAPGANOLBGL_codec);
		if (OPLBOCPIIBP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPLBOCPIIBP);
		}
		if (MGPJLHCHAME != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGPJLHCHAME);
		}
		if (AMHDFMFILBD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMHDFMFILBD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GLENEKHDKLJ other)
	{
		if (other != null)
		{
			nAPGANOLBGL_.Add(other.nAPGANOLBGL_);
			if (other.OPLBOCPIIBP != 0)
			{
				OPLBOCPIIBP = other.OPLBOCPIIBP;
			}
			if (other.MGPJLHCHAME != 0)
			{
				MGPJLHCHAME = other.MGPJLHCHAME;
			}
			if (other.AMHDFMFILBD != 0)
			{
				AMHDFMFILBD = other.AMHDFMFILBD;
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
			case 42u:
				nAPGANOLBGL_.AddEntriesFrom(ref input, _repeated_nAPGANOLBGL_codec);
				break;
			case 64u:
				OPLBOCPIIBP = input.ReadUInt32();
				break;
			case 72u:
				MGPJLHCHAME = input.ReadUInt32();
				break;
			case 80u:
				AMHDFMFILBD = input.ReadUInt32();
				break;
			}
		}
	}
}
