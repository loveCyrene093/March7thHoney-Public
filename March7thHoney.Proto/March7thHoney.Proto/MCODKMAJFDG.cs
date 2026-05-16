using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MCODKMAJFDG : IMessage<MCODKMAJFDG>, IMessage, IEquatable<MCODKMAJFDG>, IDeepCloneable<MCODKMAJFDG>, IBufferMessage
{
	private static readonly MessageParser<MCODKMAJFDG> _parser = new MessageParser<MCODKMAJFDG>(() => new MCODKMAJFDG());

	private UnknownFieldSet _unknownFields;

	public const int FPHGHAPGNAEFieldNumber = 3;

	private MLIBLHFBAFJ fPHGHAPGNAE_;

	public const int DMHLLKBMHELFieldNumber = 11;

	private ulong dMHLLKBMHEL_;

	public const int APHJIAFODHJFieldNumber = 13;

	private static readonly FieldCodec<OBPMPPCFNLJ> _repeated_aPHJIAFODHJ_codec = FieldCodec.ForMessage(106u, OBPMPPCFNLJ.Parser);

	private readonly RepeatedField<OBPMPPCFNLJ> aPHJIAFODHJ_ = new RepeatedField<OBPMPPCFNLJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MCODKMAJFDG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MCODKMAJFDGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<OBPMPPCFNLJ> APHJIAFODHJ => aPHJIAFODHJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCODKMAJFDG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCODKMAJFDG(MCODKMAJFDG other)
		: this()
	{
		fPHGHAPGNAE_ = other.fPHGHAPGNAE_;
		dMHLLKBMHEL_ = other.dMHLLKBMHEL_;
		aPHJIAFODHJ_ = other.aPHJIAFODHJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCODKMAJFDG Clone()
	{
		return new MCODKMAJFDG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MCODKMAJFDG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MCODKMAJFDG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FPHGHAPGNAE != other.FPHGHAPGNAE)
		{
			return false;
		}
		if (DMHLLKBMHEL != other.DMHLLKBMHEL)
		{
			return false;
		}
		if (!aPHJIAFODHJ_.Equals(other.aPHJIAFODHJ_))
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
		if (FPHGHAPGNAE != MLIBLHFBAFJ.Pcpdhelpkem)
		{
			num ^= FPHGHAPGNAE.GetHashCode();
		}
		if (DMHLLKBMHEL != 0L)
		{
			num ^= DMHLLKBMHEL.GetHashCode();
		}
		num ^= aPHJIAFODHJ_.GetHashCode();
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
		if (FPHGHAPGNAE != MLIBLHFBAFJ.Pcpdhelpkem)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)FPHGHAPGNAE);
		}
		if (DMHLLKBMHEL != 0L)
		{
			output.WriteRawTag(88);
			output.WriteUInt64(DMHLLKBMHEL);
		}
		aPHJIAFODHJ_.WriteTo(ref output, _repeated_aPHJIAFODHJ_codec);
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
		if (FPHGHAPGNAE != MLIBLHFBAFJ.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FPHGHAPGNAE);
		}
		if (DMHLLKBMHEL != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(DMHLLKBMHEL);
		}
		num += aPHJIAFODHJ_.CalculateSize(_repeated_aPHJIAFODHJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MCODKMAJFDG other)
	{
		if (other != null)
		{
			if (other.FPHGHAPGNAE != MLIBLHFBAFJ.Pcpdhelpkem)
			{
				FPHGHAPGNAE = other.FPHGHAPGNAE;
			}
			if (other.DMHLLKBMHEL != 0L)
			{
				DMHLLKBMHEL = other.DMHLLKBMHEL;
			}
			aPHJIAFODHJ_.Add(other.aPHJIAFODHJ_);
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
			case 24u:
				FPHGHAPGNAE = (MLIBLHFBAFJ)input.ReadEnum();
				break;
			case 88u:
				DMHLLKBMHEL = input.ReadUInt64();
				break;
			case 106u:
				aPHJIAFODHJ_.AddEntriesFrom(ref input, _repeated_aPHJIAFODHJ_codec);
				break;
			}
		}
	}
}
