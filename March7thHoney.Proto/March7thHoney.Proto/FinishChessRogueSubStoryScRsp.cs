using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishChessRogueSubStoryScRsp : IMessage<FinishChessRogueSubStoryScRsp>, IMessage, IEquatable<FinishChessRogueSubStoryScRsp>, IDeepCloneable<FinishChessRogueSubStoryScRsp>, IBufferMessage
{
	private static readonly MessageParser<FinishChessRogueSubStoryScRsp> _parser = new MessageParser<FinishChessRogueSubStoryScRsp>(() => new FinishChessRogueSubStoryScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int FAPFKFJIELEFieldNumber = 7;

	private uint fAPFKFJIELE_;

	public const int IENBKIAGPBAFieldNumber = 14;

	private uint iENBKIAGPBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishChessRogueSubStoryScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishChessRogueSubStoryScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FAPFKFJIELE
	{
		get
		{
			return fAPFKFJIELE_;
		}
		set
		{
			fAPFKFJIELE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IENBKIAGPBA
	{
		get
		{
			return iENBKIAGPBA_;
		}
		set
		{
			iENBKIAGPBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishChessRogueSubStoryScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishChessRogueSubStoryScRsp(FinishChessRogueSubStoryScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		fAPFKFJIELE_ = other.fAPFKFJIELE_;
		iENBKIAGPBA_ = other.iENBKIAGPBA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishChessRogueSubStoryScRsp Clone()
	{
		return new FinishChessRogueSubStoryScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishChessRogueSubStoryScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishChessRogueSubStoryScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (FAPFKFJIELE != other.FAPFKFJIELE)
		{
			return false;
		}
		if (IENBKIAGPBA != other.IENBKIAGPBA)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (FAPFKFJIELE != 0)
		{
			num ^= FAPFKFJIELE.GetHashCode();
		}
		if (IENBKIAGPBA != 0)
		{
			num ^= IENBKIAGPBA.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (FAPFKFJIELE != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FAPFKFJIELE);
		}
		if (IENBKIAGPBA != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(IENBKIAGPBA);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (FAPFKFJIELE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FAPFKFJIELE);
		}
		if (IENBKIAGPBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IENBKIAGPBA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishChessRogueSubStoryScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.FAPFKFJIELE != 0)
			{
				FAPFKFJIELE = other.FAPFKFJIELE;
			}
			if (other.IENBKIAGPBA != 0)
			{
				IENBKIAGPBA = other.IENBKIAGPBA;
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
				Retcode = input.ReadUInt32();
				break;
			case 56u:
				FAPFKFJIELE = input.ReadUInt32();
				break;
			case 112u:
				IENBKIAGPBA = input.ReadUInt32();
				break;
			}
		}
	}
}
