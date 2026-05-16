using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FateSyncPendingActionScNotify : IMessage<FateSyncPendingActionScNotify>, IMessage, IEquatable<FateSyncPendingActionScNotify>, IDeepCloneable<FateSyncPendingActionScNotify>, IBufferMessage
{
	private static readonly MessageParser<FateSyncPendingActionScNotify> _parser = new MessageParser<FateSyncPendingActionScNotify>(() => new FateSyncPendingActionScNotify());

	private UnknownFieldSet _unknownFields;

	public const int PendingActionFieldNumber = 10;

	private DFAHMBOGMAN pendingAction_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FateSyncPendingActionScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FateSyncPendingActionScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAHMBOGMAN PendingAction
	{
		get
		{
			return pendingAction_;
		}
		set
		{
			pendingAction_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateSyncPendingActionScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateSyncPendingActionScNotify(FateSyncPendingActionScNotify other)
		: this()
	{
		pendingAction_ = ((other.pendingAction_ != null) ? other.pendingAction_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateSyncPendingActionScNotify Clone()
	{
		return new FateSyncPendingActionScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FateSyncPendingActionScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FateSyncPendingActionScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PendingAction, other.PendingAction))
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
		if (pendingAction_ != null)
		{
			num ^= PendingAction.GetHashCode();
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
		if (pendingAction_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(PendingAction);
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
		if (pendingAction_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PendingAction);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FateSyncPendingActionScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pendingAction_ != null)
		{
			if (pendingAction_ == null)
			{
				PendingAction = new DFAHMBOGMAN();
			}
			PendingAction.MergeFrom(other.PendingAction);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (pendingAction_ == null)
			{
				PendingAction = new DFAHMBOGMAN();
			}
			input.ReadMessage(PendingAction);
		}
	}
}
