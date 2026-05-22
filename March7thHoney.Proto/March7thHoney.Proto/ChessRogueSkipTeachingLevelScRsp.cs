using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueSkipTeachingLevelScRsp : IMessage<ChessRogueSkipTeachingLevelScRsp>, IMessage, IEquatable<ChessRogueSkipTeachingLevelScRsp>, IDeepCloneable<ChessRogueSkipTeachingLevelScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueSkipTeachingLevelScRsp> _parser = new MessageParser<ChessRogueSkipTeachingLevelScRsp>(() => new ChessRogueSkipTeachingLevelScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int AIJOMBLMMOLFieldNumber = 2;

	private ItemList aIJOMBLMMOL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueSkipTeachingLevelScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueSkipTeachingLevelScRspReflection.Descriptor.MessageTypes[0];

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
	public ItemList AIJOMBLMMOL
	{
		get
		{
			return aIJOMBLMMOL_;
		}
		set
		{
			aIJOMBLMMOL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueSkipTeachingLevelScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueSkipTeachingLevelScRsp(ChessRogueSkipTeachingLevelScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		aIJOMBLMMOL_ = ((other.aIJOMBLMMOL_ != null) ? other.aIJOMBLMMOL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueSkipTeachingLevelScRsp Clone()
	{
		return new ChessRogueSkipTeachingLevelScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueSkipTeachingLevelScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueSkipTeachingLevelScRsp other)
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
		if (!object.Equals(AIJOMBLMMOL, other.AIJOMBLMMOL))
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
		if (aIJOMBLMMOL_ != null)
		{
			num ^= AIJOMBLMMOL.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (aIJOMBLMMOL_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(AIJOMBLMMOL);
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
		if (aIJOMBLMMOL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AIJOMBLMMOL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueSkipTeachingLevelScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.aIJOMBLMMOL_ != null)
		{
			if (aIJOMBLMMOL_ == null)
			{
				AIJOMBLMMOL = new ItemList();
			}
			AIJOMBLMMOL.MergeFrom(other.AIJOMBLMMOL);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				Retcode = input.ReadUInt32();
				break;
			case 18u:
				if (aIJOMBLMMOL_ == null)
				{
					AIJOMBLMMOL = new ItemList();
				}
				input.ReadMessage(AIJOMBLMMOL);
				break;
			}
		}
	}
}
