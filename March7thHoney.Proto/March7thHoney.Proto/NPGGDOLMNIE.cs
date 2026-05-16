using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NPGGDOLMNIE : IMessage<NPGGDOLMNIE>, IMessage, IEquatable<NPGGDOLMNIE>, IDeepCloneable<NPGGDOLMNIE>, IBufferMessage
{
	private static readonly MessageParser<NPGGDOLMNIE> _parser = new MessageParser<NPGGDOLMNIE>(() => new NPGGDOLMNIE());

	private UnknownFieldSet _unknownFields;

	public const int JANDBBGLJEOFieldNumber = 1;

	private uint jANDBBGLJEO_;

	public const int HEILKBJCAGBFieldNumber = 2;

	private uint hEILKBJCAGB_;

	public const int ChallengeIdFieldNumber = 13;

	private uint challengeId_;

	public const int NHICMEMJFNIFieldNumber = 14;

	private PBOFIBLBPGJ nHICMEMJFNI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NPGGDOLMNIE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NPGGDOLMNIEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JANDBBGLJEO
	{
		get
		{
			return jANDBBGLJEO_;
		}
		set
		{
			jANDBBGLJEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HEILKBJCAGB
	{
		get
		{
			return hEILKBJCAGB_;
		}
		set
		{
			hEILKBJCAGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ChallengeId
	{
		get
		{
			return challengeId_;
		}
		set
		{
			challengeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBOFIBLBPGJ NHICMEMJFNI
	{
		get
		{
			return nHICMEMJFNI_;
		}
		set
		{
			nHICMEMJFNI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPGGDOLMNIE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPGGDOLMNIE(NPGGDOLMNIE other)
		: this()
	{
		jANDBBGLJEO_ = other.jANDBBGLJEO_;
		hEILKBJCAGB_ = other.hEILKBJCAGB_;
		challengeId_ = other.challengeId_;
		nHICMEMJFNI_ = other.nHICMEMJFNI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NPGGDOLMNIE Clone()
	{
		return new NPGGDOLMNIE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NPGGDOLMNIE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NPGGDOLMNIE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JANDBBGLJEO != other.JANDBBGLJEO)
		{
			return false;
		}
		if (HEILKBJCAGB != other.HEILKBJCAGB)
		{
			return false;
		}
		if (ChallengeId != other.ChallengeId)
		{
			return false;
		}
		if (NHICMEMJFNI != other.NHICMEMJFNI)
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
		if (JANDBBGLJEO != 0)
		{
			num ^= JANDBBGLJEO.GetHashCode();
		}
		if (HEILKBJCAGB != 0)
		{
			num ^= HEILKBJCAGB.GetHashCode();
		}
		if (ChallengeId != 0)
		{
			num ^= ChallengeId.GetHashCode();
		}
		if (NHICMEMJFNI != PBOFIBLBPGJ.Ijljfpkieop)
		{
			num ^= NHICMEMJFNI.GetHashCode();
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
		if (JANDBBGLJEO != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(JANDBBGLJEO);
		}
		if (HEILKBJCAGB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(HEILKBJCAGB);
		}
		if (ChallengeId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ChallengeId);
		}
		if (NHICMEMJFNI != PBOFIBLBPGJ.Ijljfpkieop)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)NHICMEMJFNI);
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
		if (JANDBBGLJEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JANDBBGLJEO);
		}
		if (HEILKBJCAGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEILKBJCAGB);
		}
		if (ChallengeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeId);
		}
		if (NHICMEMJFNI != PBOFIBLBPGJ.Ijljfpkieop)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NHICMEMJFNI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NPGGDOLMNIE other)
	{
		if (other != null)
		{
			if (other.JANDBBGLJEO != 0)
			{
				JANDBBGLJEO = other.JANDBBGLJEO;
			}
			if (other.HEILKBJCAGB != 0)
			{
				HEILKBJCAGB = other.HEILKBJCAGB;
			}
			if (other.ChallengeId != 0)
			{
				ChallengeId = other.ChallengeId;
			}
			if (other.NHICMEMJFNI != PBOFIBLBPGJ.Ijljfpkieop)
			{
				NHICMEMJFNI = other.NHICMEMJFNI;
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
				JANDBBGLJEO = input.ReadUInt32();
				break;
			case 16u:
				HEILKBJCAGB = input.ReadUInt32();
				break;
			case 104u:
				ChallengeId = input.ReadUInt32();
				break;
			case 112u:
				NHICMEMJFNI = (PBOFIBLBPGJ)input.ReadEnum();
				break;
			}
		}
	}
}
