using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TreasureDungeonDataScNotify : IMessage<TreasureDungeonDataScNotify>, IMessage, IEquatable<TreasureDungeonDataScNotify>, IDeepCloneable<TreasureDungeonDataScNotify>, IBufferMessage
{
	private static readonly MessageParser<TreasureDungeonDataScNotify> _parser = new MessageParser<TreasureDungeonDataScNotify>(() => new TreasureDungeonDataScNotify());

	private UnknownFieldSet _unknownFields;

	public const int IKHJLMAKNCDFieldNumber = 13;

	private KPBGMOCCMLA iKHJLMAKNCD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TreasureDungeonDataScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TreasureDungeonDataScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KPBGMOCCMLA IKHJLMAKNCD
	{
		get
		{
			return iKHJLMAKNCD_;
		}
		set
		{
			iKHJLMAKNCD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureDungeonDataScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureDungeonDataScNotify(TreasureDungeonDataScNotify other)
		: this()
	{
		iKHJLMAKNCD_ = ((other.iKHJLMAKNCD_ != null) ? other.iKHJLMAKNCD_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureDungeonDataScNotify Clone()
	{
		return new TreasureDungeonDataScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TreasureDungeonDataScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TreasureDungeonDataScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IKHJLMAKNCD, other.IKHJLMAKNCD))
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
		if (iKHJLMAKNCD_ != null)
		{
			num ^= IKHJLMAKNCD.GetHashCode();
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
		if (iKHJLMAKNCD_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(IKHJLMAKNCD);
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
		if (iKHJLMAKNCD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IKHJLMAKNCD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TreasureDungeonDataScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iKHJLMAKNCD_ != null)
		{
			if (iKHJLMAKNCD_ == null)
			{
				IKHJLMAKNCD = new KPBGMOCCMLA();
			}
			IKHJLMAKNCD.MergeFrom(other.IKHJLMAKNCD);
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
			if (num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (iKHJLMAKNCD_ == null)
			{
				IKHJLMAKNCD = new KPBGMOCCMLA();
			}
			input.ReadMessage(IKHJLMAKNCD);
		}
	}
}
