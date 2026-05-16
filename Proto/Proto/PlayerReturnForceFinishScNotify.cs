using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerReturnForceFinishScNotify : IMessage<PlayerReturnForceFinishScNotify>, IMessage, IEquatable<PlayerReturnForceFinishScNotify>, IDeepCloneable<PlayerReturnForceFinishScNotify>, IBufferMessage
{
	private static readonly MessageParser<PlayerReturnForceFinishScNotify> _parser = new MessageParser<PlayerReturnForceFinishScNotify>(() => new PlayerReturnForceFinishScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CAAFBGGIBKHFieldNumber = 13;

	private KKNDEDPDFFL cAAFBGGIBKH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerReturnForceFinishScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerReturnForceFinishScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKNDEDPDFFL CAAFBGGIBKH
	{
		get
		{
			return cAAFBGGIBKH_;
		}
		set
		{
			cAAFBGGIBKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnForceFinishScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnForceFinishScNotify(PlayerReturnForceFinishScNotify other)
		: this()
	{
		cAAFBGGIBKH_ = ((other.cAAFBGGIBKH_ != null) ? other.cAAFBGGIBKH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerReturnForceFinishScNotify Clone()
	{
		return new PlayerReturnForceFinishScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerReturnForceFinishScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerReturnForceFinishScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CAAFBGGIBKH, other.CAAFBGGIBKH))
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
		if (cAAFBGGIBKH_ != null)
		{
			num ^= CAAFBGGIBKH.GetHashCode();
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
		if (cAAFBGGIBKH_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(CAAFBGGIBKH);
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
		if (cAAFBGGIBKH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CAAFBGGIBKH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerReturnForceFinishScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cAAFBGGIBKH_ != null)
		{
			if (cAAFBGGIBKH_ == null)
			{
				CAAFBGGIBKH = new KKNDEDPDFFL();
			}
			CAAFBGGIBKH.MergeFrom(other.CAAFBGGIBKH);
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
			if (cAAFBGGIBKH_ == null)
			{
				CAAFBGGIBKH = new KKNDEDPDFFL();
			}
			input.ReadMessage(CAAFBGGIBKH);
		}
	}
}
