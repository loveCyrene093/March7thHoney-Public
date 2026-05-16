using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicBoxRegularScNotify : IMessage<RelicBoxRegularScNotify>, IMessage, IEquatable<RelicBoxRegularScNotify>, IDeepCloneable<RelicBoxRegularScNotify>, IBufferMessage
{
	private static readonly MessageParser<RelicBoxRegularScNotify> _parser = new MessageParser<RelicBoxRegularScNotify>(() => new RelicBoxRegularScNotify());

	private UnknownFieldSet _unknownFields;

	public const int KKHBAPABFJCFieldNumber = 1;

	private GMONEHJIKMA kKHBAPABFJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicBoxRegularScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicBoxRegularScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GMONEHJIKMA KKHBAPABFJC
	{
		get
		{
			return kKHBAPABFJC_;
		}
		set
		{
			kKHBAPABFJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicBoxRegularScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicBoxRegularScNotify(RelicBoxRegularScNotify other)
		: this()
	{
		kKHBAPABFJC_ = ((other.kKHBAPABFJC_ != null) ? other.kKHBAPABFJC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicBoxRegularScNotify Clone()
	{
		return new RelicBoxRegularScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicBoxRegularScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicBoxRegularScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KKHBAPABFJC, other.KKHBAPABFJC))
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
		if (kKHBAPABFJC_ != null)
		{
			num ^= KKHBAPABFJC.GetHashCode();
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
		if (kKHBAPABFJC_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(KKHBAPABFJC);
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
		if (kKHBAPABFJC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KKHBAPABFJC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicBoxRegularScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kKHBAPABFJC_ != null)
		{
			if (kKHBAPABFJC_ == null)
			{
				KKHBAPABFJC = new GMONEHJIKMA();
			}
			KKHBAPABFJC.MergeFrom(other.KKHBAPABFJC);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (kKHBAPABFJC_ == null)
			{
				KKHBAPABFJC = new GMONEHJIKMA();
			}
			input.ReadMessage(KKHBAPABFJC);
		}
	}
}
