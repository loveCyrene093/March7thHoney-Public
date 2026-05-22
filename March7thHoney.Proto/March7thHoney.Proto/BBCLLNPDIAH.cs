using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BBCLLNPDIAH : IMessage<BBCLLNPDIAH>, IMessage, IEquatable<BBCLLNPDIAH>, IDeepCloneable<BBCLLNPDIAH>, IBufferMessage
{
	private static readonly MessageParser<BBCLLNPDIAH> _parser = new MessageParser<BBCLLNPDIAH>(() => new BBCLLNPDIAH());

	private UnknownFieldSet _unknownFields;

	public const int HICPAMOIFOEFieldNumber = 5;

	private uint hICPAMOIFOE_;

	public const int BOLMNNMPMNFFieldNumber = 8;

	private static readonly FieldCodec<DPBGGKCMLGM> _repeated_bOLMNNMPMNF_codec = FieldCodec.ForMessage(66u, DPBGGKCMLGM.Parser);

	private readonly RepeatedField<DPBGGKCMLGM> bOLMNNMPMNF_ = new RepeatedField<DPBGGKCMLGM>();

	public const int JKCGCAMIFIAFieldNumber = 10;

	private uint jKCGCAMIFIA_;

	public const int KAAGHAPGLCPFieldNumber = 11;

	private uint kAAGHAPGLCP_;

	public const int ODACHADOJCBFieldNumber = 15;

	private bool oDACHADOJCB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BBCLLNPDIAH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BBCLLNPDIAHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HICPAMOIFOE
	{
		get
		{
			return hICPAMOIFOE_;
		}
		set
		{
			hICPAMOIFOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DPBGGKCMLGM> BOLMNNMPMNF => bOLMNNMPMNF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKCGCAMIFIA
	{
		get
		{
			return jKCGCAMIFIA_;
		}
		set
		{
			jKCGCAMIFIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KAAGHAPGLCP
	{
		get
		{
			return kAAGHAPGLCP_;
		}
		set
		{
			kAAGHAPGLCP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ODACHADOJCB
	{
		get
		{
			return oDACHADOJCB_;
		}
		set
		{
			oDACHADOJCB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBCLLNPDIAH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBCLLNPDIAH(BBCLLNPDIAH other)
		: this()
	{
		hICPAMOIFOE_ = other.hICPAMOIFOE_;
		bOLMNNMPMNF_ = other.bOLMNNMPMNF_.Clone();
		jKCGCAMIFIA_ = other.jKCGCAMIFIA_;
		kAAGHAPGLCP_ = other.kAAGHAPGLCP_;
		oDACHADOJCB_ = other.oDACHADOJCB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBCLLNPDIAH Clone()
	{
		return new BBCLLNPDIAH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BBCLLNPDIAH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BBCLLNPDIAH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HICPAMOIFOE != other.HICPAMOIFOE)
		{
			return false;
		}
		if (!bOLMNNMPMNF_.Equals(other.bOLMNNMPMNF_))
		{
			return false;
		}
		if (JKCGCAMIFIA != other.JKCGCAMIFIA)
		{
			return false;
		}
		if (KAAGHAPGLCP != other.KAAGHAPGLCP)
		{
			return false;
		}
		if (ODACHADOJCB != other.ODACHADOJCB)
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
		if (HICPAMOIFOE != 0)
		{
			num ^= HICPAMOIFOE.GetHashCode();
		}
		num ^= bOLMNNMPMNF_.GetHashCode();
		if (JKCGCAMIFIA != 0)
		{
			num ^= JKCGCAMIFIA.GetHashCode();
		}
		if (KAAGHAPGLCP != 0)
		{
			num ^= KAAGHAPGLCP.GetHashCode();
		}
		if (ODACHADOJCB)
		{
			num ^= ODACHADOJCB.GetHashCode();
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
		if (HICPAMOIFOE != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HICPAMOIFOE);
		}
		bOLMNNMPMNF_.WriteTo(ref output, _repeated_bOLMNNMPMNF_codec);
		if (JKCGCAMIFIA != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(JKCGCAMIFIA);
		}
		if (KAAGHAPGLCP != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(KAAGHAPGLCP);
		}
		if (ODACHADOJCB)
		{
			output.WriteRawTag(120);
			output.WriteBool(ODACHADOJCB);
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
		if (HICPAMOIFOE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HICPAMOIFOE);
		}
		num += bOLMNNMPMNF_.CalculateSize(_repeated_bOLMNNMPMNF_codec);
		if (JKCGCAMIFIA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKCGCAMIFIA);
		}
		if (KAAGHAPGLCP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KAAGHAPGLCP);
		}
		if (ODACHADOJCB)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BBCLLNPDIAH other)
	{
		if (other != null)
		{
			if (other.HICPAMOIFOE != 0)
			{
				HICPAMOIFOE = other.HICPAMOIFOE;
			}
			bOLMNNMPMNF_.Add(other.bOLMNNMPMNF_);
			if (other.JKCGCAMIFIA != 0)
			{
				JKCGCAMIFIA = other.JKCGCAMIFIA;
			}
			if (other.KAAGHAPGLCP != 0)
			{
				KAAGHAPGLCP = other.KAAGHAPGLCP;
			}
			if (other.ODACHADOJCB)
			{
				ODACHADOJCB = other.ODACHADOJCB;
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
			case 40u:
				HICPAMOIFOE = input.ReadUInt32();
				break;
			case 66u:
				bOLMNNMPMNF_.AddEntriesFrom(ref input, _repeated_bOLMNNMPMNF_codec);
				break;
			case 80u:
				JKCGCAMIFIA = input.ReadUInt32();
				break;
			case 88u:
				KAAGHAPGLCP = input.ReadUInt32();
				break;
			case 120u:
				ODACHADOJCB = input.ReadBool();
				break;
			}
		}
	}
}
