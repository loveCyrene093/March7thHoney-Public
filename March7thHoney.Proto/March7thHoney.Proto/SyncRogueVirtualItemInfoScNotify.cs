using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRogueVirtualItemInfoScNotify : IMessage<SyncRogueVirtualItemInfoScNotify>, IMessage, IEquatable<SyncRogueVirtualItemInfoScNotify>, IDeepCloneable<SyncRogueVirtualItemInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRogueVirtualItemInfoScNotify> _parser = new MessageParser<SyncRogueVirtualItemInfoScNotify>(() => new SyncRogueVirtualItemInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int LHNCGDKFAGMFieldNumber = 2;

	private OOKCIAEIPON lHNCGDKFAGM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRogueVirtualItemInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRogueVirtualItemInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOKCIAEIPON LHNCGDKFAGM
	{
		get
		{
			return lHNCGDKFAGM_;
		}
		set
		{
			lHNCGDKFAGM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueVirtualItemInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueVirtualItemInfoScNotify(SyncRogueVirtualItemInfoScNotify other)
		: this()
	{
		lHNCGDKFAGM_ = ((other.lHNCGDKFAGM_ != null) ? other.lHNCGDKFAGM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueVirtualItemInfoScNotify Clone()
	{
		return new SyncRogueVirtualItemInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRogueVirtualItemInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRogueVirtualItemInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LHNCGDKFAGM, other.LHNCGDKFAGM))
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
		if (lHNCGDKFAGM_ != null)
		{
			num ^= LHNCGDKFAGM.GetHashCode();
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
		if (lHNCGDKFAGM_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(LHNCGDKFAGM);
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
		if (lHNCGDKFAGM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LHNCGDKFAGM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncRogueVirtualItemInfoScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lHNCGDKFAGM_ != null)
		{
			if (lHNCGDKFAGM_ == null)
			{
				LHNCGDKFAGM = new OOKCIAEIPON();
			}
			LHNCGDKFAGM.MergeFrom(other.LHNCGDKFAGM);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (lHNCGDKFAGM_ == null)
			{
				LHNCGDKFAGM = new OOKCIAEIPON();
			}
			input.ReadMessage(LHNCGDKFAGM);
		}
	}
}
