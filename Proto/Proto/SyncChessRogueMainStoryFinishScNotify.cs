using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncChessRogueMainStoryFinishScNotify : IMessage<SyncChessRogueMainStoryFinishScNotify>, IMessage, IEquatable<SyncChessRogueMainStoryFinishScNotify>, IDeepCloneable<SyncChessRogueMainStoryFinishScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncChessRogueMainStoryFinishScNotify> _parser = new MessageParser<SyncChessRogueMainStoryFinishScNotify>(() => new SyncChessRogueMainStoryFinishScNotify());

	private UnknownFieldSet _unknownFields;

	public const int FAPFKFJIELEFieldNumber = 2;

	private uint fAPFKFJIELE_;

	public const int MCFDKFBGHAAFieldNumber = 14;

	private uint mCFDKFBGHAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncChessRogueMainStoryFinishScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncChessRogueMainStoryFinishScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint MCFDKFBGHAA
	{
		get
		{
			return mCFDKFBGHAA_;
		}
		set
		{
			mCFDKFBGHAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChessRogueMainStoryFinishScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChessRogueMainStoryFinishScNotify(SyncChessRogueMainStoryFinishScNotify other)
		: this()
	{
		fAPFKFJIELE_ = other.fAPFKFJIELE_;
		mCFDKFBGHAA_ = other.mCFDKFBGHAA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChessRogueMainStoryFinishScNotify Clone()
	{
		return new SyncChessRogueMainStoryFinishScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncChessRogueMainStoryFinishScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncChessRogueMainStoryFinishScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FAPFKFJIELE != other.FAPFKFJIELE)
		{
			return false;
		}
		if (MCFDKFBGHAA != other.MCFDKFBGHAA)
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
		if (FAPFKFJIELE != 0)
		{
			num ^= FAPFKFJIELE.GetHashCode();
		}
		if (MCFDKFBGHAA != 0)
		{
			num ^= MCFDKFBGHAA.GetHashCode();
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
		if (FAPFKFJIELE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FAPFKFJIELE);
		}
		if (MCFDKFBGHAA != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MCFDKFBGHAA);
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
		if (FAPFKFJIELE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FAPFKFJIELE);
		}
		if (MCFDKFBGHAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MCFDKFBGHAA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncChessRogueMainStoryFinishScNotify other)
	{
		if (other != null)
		{
			if (other.FAPFKFJIELE != 0)
			{
				FAPFKFJIELE = other.FAPFKFJIELE;
			}
			if (other.MCFDKFBGHAA != 0)
			{
				MCFDKFBGHAA = other.MCFDKFBGHAA;
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
			case 16u:
				FAPFKFJIELE = input.ReadUInt32();
				break;
			case 112u:
				MCFDKFBGHAA = input.ReadUInt32();
				break;
			}
		}
	}
}
