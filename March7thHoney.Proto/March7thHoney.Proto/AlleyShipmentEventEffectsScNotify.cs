using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AlleyShipmentEventEffectsScNotify : IMessage<AlleyShipmentEventEffectsScNotify>, IMessage, IEquatable<AlleyShipmentEventEffectsScNotify>, IDeepCloneable<AlleyShipmentEventEffectsScNotify>, IBufferMessage
{
	private static readonly MessageParser<AlleyShipmentEventEffectsScNotify> _parser = new MessageParser<AlleyShipmentEventEffectsScNotify>(() => new AlleyShipmentEventEffectsScNotify());

	private UnknownFieldSet _unknownFields;

	public const int KDPAGMKNNEHFieldNumber = 1;

	private MKPDCILELAA kDPAGMKNNEH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AlleyShipmentEventEffectsScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AlleyShipmentEventEffectsScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MKPDCILELAA KDPAGMKNNEH
	{
		get
		{
			return kDPAGMKNNEH_;
		}
		set
		{
			kDPAGMKNNEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyShipmentEventEffectsScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyShipmentEventEffectsScNotify(AlleyShipmentEventEffectsScNotify other)
		: this()
	{
		kDPAGMKNNEH_ = ((other.kDPAGMKNNEH_ != null) ? other.kDPAGMKNNEH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyShipmentEventEffectsScNotify Clone()
	{
		return new AlleyShipmentEventEffectsScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AlleyShipmentEventEffectsScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AlleyShipmentEventEffectsScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KDPAGMKNNEH, other.KDPAGMKNNEH))
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
		if (kDPAGMKNNEH_ != null)
		{
			num ^= KDPAGMKNNEH.GetHashCode();
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
		if (kDPAGMKNNEH_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(KDPAGMKNNEH);
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
		if (kDPAGMKNNEH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KDPAGMKNNEH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AlleyShipmentEventEffectsScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kDPAGMKNNEH_ != null)
		{
			if (kDPAGMKNNEH_ == null)
			{
				KDPAGMKNNEH = new MKPDCILELAA();
			}
			KDPAGMKNNEH.MergeFrom(other.KDPAGMKNNEH);
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
			if (kDPAGMKNNEH_ == null)
			{
				KDPAGMKNNEH = new MKPDCILELAA();
			}
			input.ReadMessage(KDPAGMKNNEH);
		}
	}
}
