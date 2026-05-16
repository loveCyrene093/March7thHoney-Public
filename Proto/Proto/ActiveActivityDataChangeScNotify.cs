using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ActiveActivityDataChangeScNotify : IMessage<ActiveActivityDataChangeScNotify>, IMessage, IEquatable<ActiveActivityDataChangeScNotify>, IDeepCloneable<ActiveActivityDataChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<ActiveActivityDataChangeScNotify> _parser = new MessageParser<ActiveActivityDataChangeScNotify>(() => new ActiveActivityDataChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int MLBLPBLIJCAFieldNumber = 5;

	private ActiveActivityData mLBLPBLIJCA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ActiveActivityDataChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ActiveActivityDataChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActiveActivityData MLBLPBLIJCA
	{
		get
		{
			return mLBLPBLIJCA_;
		}
		set
		{
			mLBLPBLIJCA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActiveActivityDataChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActiveActivityDataChangeScNotify(ActiveActivityDataChangeScNotify other)
		: this()
	{
		mLBLPBLIJCA_ = ((other.mLBLPBLIJCA_ != null) ? other.mLBLPBLIJCA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActiveActivityDataChangeScNotify Clone()
	{
		return new ActiveActivityDataChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ActiveActivityDataChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ActiveActivityDataChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MLBLPBLIJCA, other.MLBLPBLIJCA))
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
		if (mLBLPBLIJCA_ != null)
		{
			num ^= MLBLPBLIJCA.GetHashCode();
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
		if (mLBLPBLIJCA_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(MLBLPBLIJCA);
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
		if (mLBLPBLIJCA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MLBLPBLIJCA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ActiveActivityDataChangeScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mLBLPBLIJCA_ != null)
		{
			if (mLBLPBLIJCA_ == null)
			{
				MLBLPBLIJCA = new ActiveActivityData();
			}
			MLBLPBLIJCA.MergeFrom(other.MLBLPBLIJCA);
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
			if (num != 42)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (mLBLPBLIJCA_ == null)
			{
				MLBLPBLIJCA = new ActiveActivityData();
			}
			input.ReadMessage(MLBLPBLIJCA);
		}
	}
}
