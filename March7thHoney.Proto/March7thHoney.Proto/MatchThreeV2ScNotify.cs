using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MatchThreeV2ScNotify : IMessage<MatchThreeV2ScNotify>, IMessage, IEquatable<MatchThreeV2ScNotify>, IDeepCloneable<MatchThreeV2ScNotify>, IBufferMessage
{
	private static readonly MessageParser<MatchThreeV2ScNotify> _parser = new MessageParser<MatchThreeV2ScNotify>(() => new MatchThreeV2ScNotify());

	private UnknownFieldSet _unknownFields;

	public const int KJHGGPEMPHMFieldNumber = 6;

	private NOJLPMLALPI kJHGGPEMPHM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MatchThreeV2ScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MatchThreeV2ScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOJLPMLALPI KJHGGPEMPHM
	{
		get
		{
			return kJHGGPEMPHM_;
		}
		set
		{
			kJHGGPEMPHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2ScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2ScNotify(MatchThreeV2ScNotify other)
		: this()
	{
		kJHGGPEMPHM_ = ((other.kJHGGPEMPHM_ != null) ? other.kJHGGPEMPHM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2ScNotify Clone()
	{
		return new MatchThreeV2ScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MatchThreeV2ScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MatchThreeV2ScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KJHGGPEMPHM, other.KJHGGPEMPHM))
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
		if (kJHGGPEMPHM_ != null)
		{
			num ^= KJHGGPEMPHM.GetHashCode();
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
		if (kJHGGPEMPHM_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(KJHGGPEMPHM);
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
		if (kJHGGPEMPHM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KJHGGPEMPHM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MatchThreeV2ScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kJHGGPEMPHM_ != null)
		{
			if (kJHGGPEMPHM_ == null)
			{
				KJHGGPEMPHM = new NOJLPMLALPI();
			}
			KJHGGPEMPHM.MergeFrom(other.KJHGGPEMPHM);
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
			if (num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (kJHGGPEMPHM_ == null)
			{
				KJHGGPEMPHM = new NOJLPMLALPI();
			}
			input.ReadMessage(KJHGGPEMPHM);
		}
	}
}
