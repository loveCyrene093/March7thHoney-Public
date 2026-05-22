using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HPHMMPDFMAK : IMessage<HPHMMPDFMAK>, IMessage, IEquatable<HPHMMPDFMAK>, IDeepCloneable<HPHMMPDFMAK>, IBufferMessage
{
	private static readonly MessageParser<HPHMMPDFMAK> _parser = new MessageParser<HPHMMPDFMAK>(() => new HPHMMPDFMAK());

	private UnknownFieldSet _unknownFields;

	public const int SlotFieldNumber = 3;

	private uint slot_;

	public const int LineupFieldNumber = 15;

	private DKDGGGCDAGM lineup_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HPHMMPDFMAK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HPHMMPDFMAKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Slot
	{
		get
		{
			return slot_;
		}
		set
		{
			slot_ = value;
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
	public HPHMMPDFMAK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HPHMMPDFMAK(HPHMMPDFMAK other)
		: this()
	{
		slot_ = other.slot_;
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HPHMMPDFMAK Clone()
	{
		return new HPHMMPDFMAK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HPHMMPDFMAK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HPHMMPDFMAK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Slot != other.Slot)
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
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
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
		if (Slot != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Slot);
		}
		if (lineup_ != null)
		{
			output.WriteRawTag(122);
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
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Slot);
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
	public void MergeFrom(HPHMMPDFMAK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Slot != 0)
		{
			Slot = other.Slot;
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
			case 24u:
				Slot = input.ReadUInt32();
				break;
			case 122u:
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
