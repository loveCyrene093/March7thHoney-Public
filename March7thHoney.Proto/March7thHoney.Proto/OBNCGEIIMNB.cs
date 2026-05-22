using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OBNCGEIIMNB : IMessage<OBNCGEIIMNB>, IMessage, IEquatable<OBNCGEIIMNB>, IDeepCloneable<OBNCGEIIMNB>, IBufferMessage
{
	private static readonly MessageParser<OBNCGEIIMNB> _parser = new MessageParser<OBNCGEIIMNB>(() => new OBNCGEIIMNB());

	private UnknownFieldSet _unknownFields;

	public const int APHJIAFODHJFieldNumber = 5;

	private static readonly FieldCodec<OBPMPPCFNLJ> _repeated_aPHJIAFODHJ_codec = FieldCodec.ForMessage(42u, OBPMPPCFNLJ.Parser);

	private readonly RepeatedField<OBPMPPCFNLJ> aPHJIAFODHJ_ = new RepeatedField<OBPMPPCFNLJ>();

	public const int FPHGHAPGNAEFieldNumber = 6;

	private MLIBLHFBAFJ fPHGHAPGNAE_;

	public const int DMHLLKBMHELFieldNumber = 7;

	private ulong dMHLLKBMHEL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OBNCGEIIMNB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OBNCGEIIMNBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OBPMPPCFNLJ> APHJIAFODHJ => aPHJIAFODHJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLIBLHFBAFJ FPHGHAPGNAE
	{
		get
		{
			return fPHGHAPGNAE_;
		}
		set
		{
			fPHGHAPGNAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong DMHLLKBMHEL
	{
		get
		{
			return dMHLLKBMHEL_;
		}
		set
		{
			dMHLLKBMHEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBNCGEIIMNB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBNCGEIIMNB(OBNCGEIIMNB other)
		: this()
	{
		aPHJIAFODHJ_ = other.aPHJIAFODHJ_.Clone();
		fPHGHAPGNAE_ = other.fPHGHAPGNAE_;
		dMHLLKBMHEL_ = other.dMHLLKBMHEL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBNCGEIIMNB Clone()
	{
		return new OBNCGEIIMNB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OBNCGEIIMNB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OBNCGEIIMNB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aPHJIAFODHJ_.Equals(other.aPHJIAFODHJ_))
		{
			return false;
		}
		if (FPHGHAPGNAE != other.FPHGHAPGNAE)
		{
			return false;
		}
		if (DMHLLKBMHEL != other.DMHLLKBMHEL)
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
		num ^= aPHJIAFODHJ_.GetHashCode();
		if (FPHGHAPGNAE != MLIBLHFBAFJ.Pcpdhelpkem)
		{
			num ^= FPHGHAPGNAE.GetHashCode();
		}
		if (DMHLLKBMHEL != 0L)
		{
			num ^= DMHLLKBMHEL.GetHashCode();
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
		aPHJIAFODHJ_.WriteTo(ref output, _repeated_aPHJIAFODHJ_codec);
		if (FPHGHAPGNAE != MLIBLHFBAFJ.Pcpdhelpkem)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)FPHGHAPGNAE);
		}
		if (DMHLLKBMHEL != 0L)
		{
			output.WriteRawTag(56);
			output.WriteUInt64(DMHLLKBMHEL);
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
		num += aPHJIAFODHJ_.CalculateSize(_repeated_aPHJIAFODHJ_codec);
		if (FPHGHAPGNAE != MLIBLHFBAFJ.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FPHGHAPGNAE);
		}
		if (DMHLLKBMHEL != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(DMHLLKBMHEL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OBNCGEIIMNB other)
	{
		if (other != null)
		{
			aPHJIAFODHJ_.Add(other.aPHJIAFODHJ_);
			if (other.FPHGHAPGNAE != MLIBLHFBAFJ.Pcpdhelpkem)
			{
				FPHGHAPGNAE = other.FPHGHAPGNAE;
			}
			if (other.DMHLLKBMHEL != 0L)
			{
				DMHLLKBMHEL = other.DMHLLKBMHEL;
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
				aPHJIAFODHJ_.AddEntriesFrom(ref input, _repeated_aPHJIAFODHJ_codec);
				break;
			case 48u:
				FPHGHAPGNAE = (MLIBLHFBAFJ)input.ReadEnum();
				break;
			case 56u:
				DMHLLKBMHEL = input.ReadUInt64();
				break;
			}
		}
	}
}
