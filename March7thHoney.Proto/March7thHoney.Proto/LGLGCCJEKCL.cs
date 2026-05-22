using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LGLGCCJEKCL : IMessage<LGLGCCJEKCL>, IMessage, IEquatable<LGLGCCJEKCL>, IDeepCloneable<LGLGCCJEKCL>, IBufferMessage
{
	private static readonly MessageParser<LGLGCCJEKCL> _parser = new MessageParser<LGLGCCJEKCL>(() => new LGLGCCJEKCL());

	private UnknownFieldSet _unknownFields;

	public const int KHDLMPAKEGFFieldNumber = 7;

	private float kHDLMPAKEGF_;

	public const int NIKEEDLJHPDFieldNumber = 8;

	private bool nIKEEDLJHPD_;

	public const int ArgIdFieldNumber = 11;

	private uint argId_;

	public const int BGJKBPNCNLEFieldNumber = 12;

	private int bGJKBPNCNLE_;

	public const int RogueDialogueEventIdFieldNumber = 13;

	private uint rogueDialogueEventId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LGLGCCJEKCL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LGLGCCJEKCLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float KHDLMPAKEGF
	{
		get
		{
			return kHDLMPAKEGF_;
		}
		set
		{
			kHDLMPAKEGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NIKEEDLJHPD
	{
		get
		{
			return nIKEEDLJHPD_;
		}
		set
		{
			nIKEEDLJHPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ArgId
	{
		get
		{
			return argId_;
		}
		set
		{
			argId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BGJKBPNCNLE
	{
		get
		{
			return bGJKBPNCNLE_;
		}
		set
		{
			bGJKBPNCNLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RogueDialogueEventId
	{
		get
		{
			return rogueDialogueEventId_;
		}
		set
		{
			rogueDialogueEventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGLGCCJEKCL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGLGCCJEKCL(LGLGCCJEKCL other)
		: this()
	{
		kHDLMPAKEGF_ = other.kHDLMPAKEGF_;
		nIKEEDLJHPD_ = other.nIKEEDLJHPD_;
		argId_ = other.argId_;
		bGJKBPNCNLE_ = other.bGJKBPNCNLE_;
		rogueDialogueEventId_ = other.rogueDialogueEventId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGLGCCJEKCL Clone()
	{
		return new LGLGCCJEKCL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LGLGCCJEKCL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LGLGCCJEKCL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(KHDLMPAKEGF, other.KHDLMPAKEGF))
		{
			return false;
		}
		if (NIKEEDLJHPD != other.NIKEEDLJHPD)
		{
			return false;
		}
		if (ArgId != other.ArgId)
		{
			return false;
		}
		if (BGJKBPNCNLE != other.BGJKBPNCNLE)
		{
			return false;
		}
		if (RogueDialogueEventId != other.RogueDialogueEventId)
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
		if (KHDLMPAKEGF != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(KHDLMPAKEGF);
		}
		if (NIKEEDLJHPD)
		{
			num ^= NIKEEDLJHPD.GetHashCode();
		}
		if (ArgId != 0)
		{
			num ^= ArgId.GetHashCode();
		}
		if (BGJKBPNCNLE != 0)
		{
			num ^= BGJKBPNCNLE.GetHashCode();
		}
		if (RogueDialogueEventId != 0)
		{
			num ^= RogueDialogueEventId.GetHashCode();
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
		if (KHDLMPAKEGF != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(KHDLMPAKEGF);
		}
		if (NIKEEDLJHPD)
		{
			output.WriteRawTag(64);
			output.WriteBool(NIKEEDLJHPD);
		}
		if (ArgId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ArgId);
		}
		if (BGJKBPNCNLE != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(BGJKBPNCNLE);
		}
		if (RogueDialogueEventId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(RogueDialogueEventId);
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
		if (KHDLMPAKEGF != 0f)
		{
			num += 5;
		}
		if (NIKEEDLJHPD)
		{
			num += 2;
		}
		if (ArgId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ArgId);
		}
		if (BGJKBPNCNLE != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BGJKBPNCNLE);
		}
		if (RogueDialogueEventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RogueDialogueEventId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LGLGCCJEKCL other)
	{
		if (other != null)
		{
			if (other.KHDLMPAKEGF != 0f)
			{
				KHDLMPAKEGF = other.KHDLMPAKEGF;
			}
			if (other.NIKEEDLJHPD)
			{
				NIKEEDLJHPD = other.NIKEEDLJHPD;
			}
			if (other.ArgId != 0)
			{
				ArgId = other.ArgId;
			}
			if (other.BGJKBPNCNLE != 0)
			{
				BGJKBPNCNLE = other.BGJKBPNCNLE;
			}
			if (other.RogueDialogueEventId != 0)
			{
				RogueDialogueEventId = other.RogueDialogueEventId;
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
			case 61u:
				KHDLMPAKEGF = input.ReadFloat();
				break;
			case 64u:
				NIKEEDLJHPD = input.ReadBool();
				break;
			case 88u:
				ArgId = input.ReadUInt32();
				break;
			case 96u:
				BGJKBPNCNLE = input.ReadInt32();
				break;
			case 104u:
				RogueDialogueEventId = input.ReadUInt32();
				break;
			}
		}
	}
}
