using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournReviveCostUpdateScNotify : IMessage<RogueTournReviveCostUpdateScNotify>, IMessage, IEquatable<RogueTournReviveCostUpdateScNotify>, IDeepCloneable<RogueTournReviveCostUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<RogueTournReviveCostUpdateScNotify> _parser = new MessageParser<RogueTournReviveCostUpdateScNotify>(() => new RogueTournReviveCostUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int EBMKBDJMAAFFieldNumber = 7;

	private ItemCostData eBMKBDJMAAF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournReviveCostUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournReviveCostUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData EBMKBDJMAAF
	{
		get
		{
			return eBMKBDJMAAF_;
		}
		set
		{
			eBMKBDJMAAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournReviveCostUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournReviveCostUpdateScNotify(RogueTournReviveCostUpdateScNotify other)
		: this()
	{
		eBMKBDJMAAF_ = ((other.eBMKBDJMAAF_ != null) ? other.eBMKBDJMAAF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournReviveCostUpdateScNotify Clone()
	{
		return new RogueTournReviveCostUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournReviveCostUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournReviveCostUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EBMKBDJMAAF, other.EBMKBDJMAAF))
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
		if (eBMKBDJMAAF_ != null)
		{
			num ^= EBMKBDJMAAF.GetHashCode();
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
		if (eBMKBDJMAAF_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(EBMKBDJMAAF);
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
		if (eBMKBDJMAAF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EBMKBDJMAAF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournReviveCostUpdateScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eBMKBDJMAAF_ != null)
		{
			if (eBMKBDJMAAF_ == null)
			{
				EBMKBDJMAAF = new ItemCostData();
			}
			EBMKBDJMAAF.MergeFrom(other.EBMKBDJMAAF);
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
			if (num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (eBMKBDJMAAF_ == null)
			{
				EBMKBDJMAAF = new ItemCostData();
			}
			input.ReadMessage(EBMKBDJMAAF);
		}
	}
}
