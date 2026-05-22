using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueCellUpdateNotify : IMessage<ChessRogueCellUpdateNotify>, IMessage, IEquatable<ChessRogueCellUpdateNotify>, IDeepCloneable<ChessRogueCellUpdateNotify>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueCellUpdateNotify> _parser = new MessageParser<ChessRogueCellUpdateNotify>(() => new ChessRogueCellUpdateNotify());

	private UnknownFieldSet _unknownFields;

	public const int DDPKJKHEDLHFieldNumber = 5;

	private static readonly FieldCodec<NAKIGLPGKBA> _repeated_dDPKJKHEDLH_codec = FieldCodec.ForMessage(42u, NAKIGLPGKBA.Parser);

	private readonly RepeatedField<NAKIGLPGKBA> dDPKJKHEDLH_ = new RepeatedField<NAKIGLPGKBA>();

	public const int ReasonFieldNumber = 11;

	private BGOBBOMLJCM reason_;

	public const int OHHGAAKGLDOFieldNumber = 14;

	private uint oHHGAAKGLDO_;

	public const int FPAFHBPBHEFFieldNumber = 15;

	private RogueModifierSourceType fPAFHBPBHEF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueCellUpdateNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueCellUpdateNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NAKIGLPGKBA> DDPKJKHEDLH => dDPKJKHEDLH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGOBBOMLJCM Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OHHGAAKGLDO
	{
		get
		{
			return oHHGAAKGLDO_;
		}
		set
		{
			oHHGAAKGLDO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueModifierSourceType FPAFHBPBHEF
	{
		get
		{
			return fPAFHBPBHEF_;
		}
		set
		{
			fPAFHBPBHEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueCellUpdateNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueCellUpdateNotify(ChessRogueCellUpdateNotify other)
		: this()
	{
		dDPKJKHEDLH_ = other.dDPKJKHEDLH_.Clone();
		reason_ = other.reason_;
		oHHGAAKGLDO_ = other.oHHGAAKGLDO_;
		fPAFHBPBHEF_ = other.fPAFHBPBHEF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueCellUpdateNotify Clone()
	{
		return new ChessRogueCellUpdateNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueCellUpdateNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueCellUpdateNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dDPKJKHEDLH_.Equals(other.dDPKJKHEDLH_))
		{
			return false;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (OHHGAAKGLDO != other.OHHGAAKGLDO)
		{
			return false;
		}
		if (FPAFHBPBHEF != other.FPAFHBPBHEF)
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
		num ^= dDPKJKHEDLH_.GetHashCode();
		if (Reason != BGOBBOMLJCM.Pcpdhelpkem)
		{
			num ^= Reason.GetHashCode();
		}
		if (OHHGAAKGLDO != 0)
		{
			num ^= OHHGAAKGLDO.GetHashCode();
		}
		if (FPAFHBPBHEF != RogueModifierSourceType.KiellbkoaloChodnmohlpn)
		{
			num ^= FPAFHBPBHEF.GetHashCode();
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
		dDPKJKHEDLH_.WriteTo(ref output, _repeated_dDPKJKHEDLH_codec);
		if (Reason != BGOBBOMLJCM.Pcpdhelpkem)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)Reason);
		}
		if (OHHGAAKGLDO != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(OHHGAAKGLDO);
		}
		if (FPAFHBPBHEF != RogueModifierSourceType.KiellbkoaloChodnmohlpn)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)FPAFHBPBHEF);
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
		num += dDPKJKHEDLH_.CalculateSize(_repeated_dDPKJKHEDLH_codec);
		if (Reason != BGOBBOMLJCM.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (OHHGAAKGLDO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OHHGAAKGLDO);
		}
		if (FPAFHBPBHEF != RogueModifierSourceType.KiellbkoaloChodnmohlpn)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FPAFHBPBHEF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueCellUpdateNotify other)
	{
		if (other != null)
		{
			dDPKJKHEDLH_.Add(other.dDPKJKHEDLH_);
			if (other.Reason != BGOBBOMLJCM.Pcpdhelpkem)
			{
				Reason = other.Reason;
			}
			if (other.OHHGAAKGLDO != 0)
			{
				OHHGAAKGLDO = other.OHHGAAKGLDO;
			}
			if (other.FPAFHBPBHEF != RogueModifierSourceType.KiellbkoaloChodnmohlpn)
			{
				FPAFHBPBHEF = other.FPAFHBPBHEF;
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
				dDPKJKHEDLH_.AddEntriesFrom(ref input, _repeated_dDPKJKHEDLH_codec);
				break;
			case 88u:
				Reason = (BGOBBOMLJCM)input.ReadEnum();
				break;
			case 112u:
				OHHGAAKGLDO = input.ReadUInt32();
				break;
			case 120u:
				FPAFHBPBHEF = (RogueModifierSourceType)input.ReadEnum();
				break;
			}
		}
	}
}
