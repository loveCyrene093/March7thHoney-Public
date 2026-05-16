using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MALGHKMBKOK : IMessage<MALGHKMBKOK>, IMessage, IEquatable<MALGHKMBKOK>, IDeepCloneable<MALGHKMBKOK>, IBufferMessage
{
	private static readonly MessageParser<MALGHKMBKOK> _parser = new MessageParser<MALGHKMBKOK>(() => new MALGHKMBKOK());

	private UnknownFieldSet _unknownFields;

	public const int ScoreIdFieldNumber = 4;

	private uint scoreId_;

	public const int UidFieldNumber = 6;

	private uint uid_;

	public const int LineupFieldNumber = 12;

	private DKDGGGCDAGM lineup_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MALGHKMBKOK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MALGHKMBKOKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKDGGGCDAGM Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MALGHKMBKOK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MALGHKMBKOK(MALGHKMBKOK other)
		: this()
	{
		scoreId_ = other.scoreId_;
		uid_ = other.uid_;
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MALGHKMBKOK Clone()
	{
		return new MALGHKMBKOK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MALGHKMBKOK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MALGHKMBKOK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (!object.Equals(Lineup, other.Lineup))
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
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
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
		if (ScoreId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ScoreId);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Uid);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(Lineup);
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
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MALGHKMBKOK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		if (other.Uid != 0)
		{
			Uid = other.Uid;
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new DKDGGGCDAGM();
			}
			Lineup.MergeFrom(other.Lineup);
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
			case 32u:
				ScoreId = input.ReadUInt32();
				break;
			case 48u:
				Uid = input.ReadUInt32();
				break;
			case 98u:
				if (lineup_ == null)
				{
					Lineup = new DKDGGGCDAGM();
				}
				input.ReadMessage(Lineup);
				break;
			}
		}
	}
}
