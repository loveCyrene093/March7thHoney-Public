using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FNONPMBOFNE : IMessage<FNONPMBOFNE>, IMessage, IEquatable<FNONPMBOFNE>, IDeepCloneable<FNONPMBOFNE>, IBufferMessage
{
	private static readonly MessageParser<FNONPMBOFNE> _parser = new MessageParser<FNONPMBOFNE>(() => new FNONPMBOFNE());

	private UnknownFieldSet _unknownFields;

	public const int FMIGAEFJBOKFieldNumber = 1;

	private bool fMIGAEFJBOK_;

	public const int UniqueIdFieldNumber = 7;

	private uint uniqueId_;

	public const int MonsterListFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_monsterList_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> monsterList_ = new RepeatedField<uint>();

	public const int LJKGCMOPHIFFieldNumber = 13;

	private bool lJKGCMOPHIF_;

	public const int AffixIdFieldNumber = 15;

	private uint affixId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FNONPMBOFNE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FNONPMBOFNEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FMIGAEFJBOK
	{
		get
		{
			return fMIGAEFJBOK_;
		}
		set
		{
			fMIGAEFJBOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MonsterList => monsterList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool LJKGCMOPHIF
	{
		get
		{
			return lJKGCMOPHIF_;
		}
		set
		{
			lJKGCMOPHIF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AffixId
	{
		get
		{
			return affixId_;
		}
		set
		{
			affixId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNONPMBOFNE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNONPMBOFNE(FNONPMBOFNE other)
		: this()
	{
		fMIGAEFJBOK_ = other.fMIGAEFJBOK_;
		uniqueId_ = other.uniqueId_;
		monsterList_ = other.monsterList_.Clone();
		lJKGCMOPHIF_ = other.lJKGCMOPHIF_;
		affixId_ = other.affixId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNONPMBOFNE Clone()
	{
		return new FNONPMBOFNE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FNONPMBOFNE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FNONPMBOFNE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FMIGAEFJBOK != other.FMIGAEFJBOK)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!monsterList_.Equals(other.monsterList_))
		{
			return false;
		}
		if (LJKGCMOPHIF != other.LJKGCMOPHIF)
		{
			return false;
		}
		if (AffixId != other.AffixId)
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
		if (FMIGAEFJBOK)
		{
			num ^= FMIGAEFJBOK.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		num ^= monsterList_.GetHashCode();
		if (LJKGCMOPHIF)
		{
			num ^= LJKGCMOPHIF.GetHashCode();
		}
		if (AffixId != 0)
		{
			num ^= AffixId.GetHashCode();
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
		if (FMIGAEFJBOK)
		{
			output.WriteRawTag(8);
			output.WriteBool(FMIGAEFJBOK);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(UniqueId);
		}
		monsterList_.WriteTo(ref output, _repeated_monsterList_codec);
		if (LJKGCMOPHIF)
		{
			output.WriteRawTag(104);
			output.WriteBool(LJKGCMOPHIF);
		}
		if (AffixId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(AffixId);
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
		if (FMIGAEFJBOK)
		{
			num += 2;
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		num += monsterList_.CalculateSize(_repeated_monsterList_codec);
		if (LJKGCMOPHIF)
		{
			num += 2;
		}
		if (AffixId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AffixId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FNONPMBOFNE other)
	{
		if (other != null)
		{
			if (other.FMIGAEFJBOK)
			{
				FMIGAEFJBOK = other.FMIGAEFJBOK;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			monsterList_.Add(other.monsterList_);
			if (other.LJKGCMOPHIF)
			{
				LJKGCMOPHIF = other.LJKGCMOPHIF;
			}
			if (other.AffixId != 0)
			{
				AffixId = other.AffixId;
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
			case 8u:
				FMIGAEFJBOK = input.ReadBool();
				break;
			case 56u:
				UniqueId = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				monsterList_.AddEntriesFrom(ref input, _repeated_monsterList_codec);
				break;
			case 104u:
				LJKGCMOPHIF = input.ReadBool();
				break;
			case 120u:
				AffixId = input.ReadUInt32();
				break;
			}
		}
	}
}
