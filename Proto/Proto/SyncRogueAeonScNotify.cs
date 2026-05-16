using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRogueAeonScNotify : IMessage<SyncRogueAeonScNotify>, IMessage, IEquatable<SyncRogueAeonScNotify>, IDeepCloneable<SyncRogueAeonScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRogueAeonScNotify> _parser = new MessageParser<SyncRogueAeonScNotify>(() => new SyncRogueAeonScNotify());

	private UnknownFieldSet _unknownFields;

	public const int EGFBGJGIEKMFieldNumber = 4;

	private EMFHHDMODEB eGFBGJGIEKM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRogueAeonScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRogueAeonScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMFHHDMODEB EGFBGJGIEKM
	{
		get
		{
			return eGFBGJGIEKM_;
		}
		set
		{
			eGFBGJGIEKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueAeonScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueAeonScNotify(SyncRogueAeonScNotify other)
		: this()
	{
		eGFBGJGIEKM_ = ((other.eGFBGJGIEKM_ != null) ? other.eGFBGJGIEKM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueAeonScNotify Clone()
	{
		return new SyncRogueAeonScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRogueAeonScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRogueAeonScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EGFBGJGIEKM, other.EGFBGJGIEKM))
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
		if (eGFBGJGIEKM_ != null)
		{
			num ^= EGFBGJGIEKM.GetHashCode();
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
		if (eGFBGJGIEKM_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(EGFBGJGIEKM);
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
		if (eGFBGJGIEKM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EGFBGJGIEKM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncRogueAeonScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eGFBGJGIEKM_ != null)
		{
			if (eGFBGJGIEKM_ == null)
			{
				EGFBGJGIEKM = new EMFHHDMODEB();
			}
			EGFBGJGIEKM.MergeFrom(other.EGFBGJGIEKM);
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
			if (num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (eGFBGJGIEKM_ == null)
			{
				EGFBGJGIEKM = new EMFHHDMODEB();
			}
			input.ReadMessage(EGFBGJGIEKM);
		}
	}
}
