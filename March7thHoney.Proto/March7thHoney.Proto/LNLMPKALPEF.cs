using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LNLMPKALPEF : IMessage<LNLMPKALPEF>, IMessage, IEquatable<LNLMPKALPEF>, IDeepCloneable<LNLMPKALPEF>, IBufferMessage
{
	private static readonly MessageParser<LNLMPKALPEF> _parser = new MessageParser<LNLMPKALPEF>(() => new LNLMPKALPEF());

	private UnknownFieldSet _unknownFields;

	public const int FHKEMCLFBONFieldNumber = 1;

	private GDKPBDAAKBH fHKEMCLFBON_;

	public const int BHFDLCPEPHMFieldNumber = 2;

	private uint bHFDLCPEPHM_;

	public const int AOLHMEFDAHEFieldNumber = 9;

	private uint aOLHMEFDAHE_;

	public const int JBOCOPNEJLBFieldNumber = 13;

	private static readonly FieldCodec<ANBOFKHHDNE> _repeated_jBOCOPNEJLB_codec = FieldCodec.ForMessage(106u, ANBOFKHHDNE.Parser);

	private readonly RepeatedField<ANBOFKHHDNE> jBOCOPNEJLB_ = new RepeatedField<ANBOFKHHDNE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LNLMPKALPEF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LNLMPKALPEFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDKPBDAAKBH FHKEMCLFBON
	{
		get
		{
			return fHKEMCLFBON_;
		}
		set
		{
			fHKEMCLFBON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BHFDLCPEPHM
	{
		get
		{
			return bHFDLCPEPHM_;
		}
		set
		{
			bHFDLCPEPHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AOLHMEFDAHE
	{
		get
		{
			return aOLHMEFDAHE_;
		}
		set
		{
			aOLHMEFDAHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ANBOFKHHDNE> JBOCOPNEJLB => jBOCOPNEJLB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNLMPKALPEF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNLMPKALPEF(LNLMPKALPEF other)
		: this()
	{
		fHKEMCLFBON_ = ((other.fHKEMCLFBON_ != null) ? other.fHKEMCLFBON_.Clone() : null);
		bHFDLCPEPHM_ = other.bHFDLCPEPHM_;
		aOLHMEFDAHE_ = other.aOLHMEFDAHE_;
		jBOCOPNEJLB_ = other.jBOCOPNEJLB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNLMPKALPEF Clone()
	{
		return new LNLMPKALPEF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LNLMPKALPEF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LNLMPKALPEF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FHKEMCLFBON, other.FHKEMCLFBON))
		{
			return false;
		}
		if (BHFDLCPEPHM != other.BHFDLCPEPHM)
		{
			return false;
		}
		if (AOLHMEFDAHE != other.AOLHMEFDAHE)
		{
			return false;
		}
		if (!jBOCOPNEJLB_.Equals(other.jBOCOPNEJLB_))
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
		if (fHKEMCLFBON_ != null)
		{
			num ^= FHKEMCLFBON.GetHashCode();
		}
		if (BHFDLCPEPHM != 0)
		{
			num ^= BHFDLCPEPHM.GetHashCode();
		}
		if (AOLHMEFDAHE != 0)
		{
			num ^= AOLHMEFDAHE.GetHashCode();
		}
		num ^= jBOCOPNEJLB_.GetHashCode();
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
		if (fHKEMCLFBON_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(FHKEMCLFBON);
		}
		if (BHFDLCPEPHM != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BHFDLCPEPHM);
		}
		if (AOLHMEFDAHE != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(AOLHMEFDAHE);
		}
		jBOCOPNEJLB_.WriteTo(ref output, _repeated_jBOCOPNEJLB_codec);
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
		if (fHKEMCLFBON_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FHKEMCLFBON);
		}
		if (BHFDLCPEPHM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BHFDLCPEPHM);
		}
		if (AOLHMEFDAHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AOLHMEFDAHE);
		}
		num += jBOCOPNEJLB_.CalculateSize(_repeated_jBOCOPNEJLB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LNLMPKALPEF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fHKEMCLFBON_ != null)
		{
			if (fHKEMCLFBON_ == null)
			{
				FHKEMCLFBON = new GDKPBDAAKBH();
			}
			FHKEMCLFBON.MergeFrom(other.FHKEMCLFBON);
		}
		if (other.BHFDLCPEPHM != 0)
		{
			BHFDLCPEPHM = other.BHFDLCPEPHM;
		}
		if (other.AOLHMEFDAHE != 0)
		{
			AOLHMEFDAHE = other.AOLHMEFDAHE;
		}
		jBOCOPNEJLB_.Add(other.jBOCOPNEJLB_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (fHKEMCLFBON_ == null)
				{
					FHKEMCLFBON = new GDKPBDAAKBH();
				}
				input.ReadMessage(FHKEMCLFBON);
				break;
			case 16u:
				BHFDLCPEPHM = input.ReadUInt32();
				break;
			case 72u:
				AOLHMEFDAHE = input.ReadUInt32();
				break;
			case 106u:
				jBOCOPNEJLB_.AddEntriesFrom(ref input, _repeated_jBOCOPNEJLB_codec);
				break;
			}
		}
	}
}
