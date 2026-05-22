using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetChessRogueStoryAeonTalkInfoCsReq : IMessage<GetChessRogueStoryAeonTalkInfoCsReq>, IMessage, IEquatable<GetChessRogueStoryAeonTalkInfoCsReq>, IDeepCloneable<GetChessRogueStoryAeonTalkInfoCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetChessRogueStoryAeonTalkInfoCsReq> _parser = new MessageParser<GetChessRogueStoryAeonTalkInfoCsReq>(() => new GetChessRogueStoryAeonTalkInfoCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AHKFFCIEPDGFieldNumber = 12;

	private uint aHKFFCIEPDG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetChessRogueStoryAeonTalkInfoCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetChessRogueStoryAeonTalkInfoCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AHKFFCIEPDG
	{
		get
		{
			return aHKFFCIEPDG_;
		}
		set
		{
			aHKFFCIEPDG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChessRogueStoryAeonTalkInfoCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChessRogueStoryAeonTalkInfoCsReq(GetChessRogueStoryAeonTalkInfoCsReq other)
		: this()
	{
		aHKFFCIEPDG_ = other.aHKFFCIEPDG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChessRogueStoryAeonTalkInfoCsReq Clone()
	{
		return new GetChessRogueStoryAeonTalkInfoCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetChessRogueStoryAeonTalkInfoCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetChessRogueStoryAeonTalkInfoCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AHKFFCIEPDG != other.AHKFFCIEPDG)
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
		if (AHKFFCIEPDG != 0)
		{
			num ^= AHKFFCIEPDG.GetHashCode();
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
		if (AHKFFCIEPDG != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(AHKFFCIEPDG);
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
		if (AHKFFCIEPDG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AHKFFCIEPDG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetChessRogueStoryAeonTalkInfoCsReq other)
	{
		if (other != null)
		{
			if (other.AHKFFCIEPDG != 0)
			{
				AHKFFCIEPDG = other.AHKFFCIEPDG;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				AHKFFCIEPDG = input.ReadUInt32();
			}
		}
	}
}
