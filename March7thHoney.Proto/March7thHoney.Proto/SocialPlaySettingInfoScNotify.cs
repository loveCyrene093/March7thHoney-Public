using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SocialPlaySettingInfoScNotify : IMessage<SocialPlaySettingInfoScNotify>, IMessage, IEquatable<SocialPlaySettingInfoScNotify>, IDeepCloneable<SocialPlaySettingInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<SocialPlaySettingInfoScNotify> _parser = new MessageParser<SocialPlaySettingInfoScNotify>(() => new SocialPlaySettingInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ONBKNHFOPONFieldNumber = 4;

	private NECGMCGFANN oNBKNHFOPON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SocialPlaySettingInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SocialPlaySettingInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NECGMCGFANN ONBKNHFOPON
	{
		get
		{
			return oNBKNHFOPON_;
		}
		set
		{
			oNBKNHFOPON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlaySettingInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlaySettingInfoScNotify(SocialPlaySettingInfoScNotify other)
		: this()
	{
		oNBKNHFOPON_ = ((other.oNBKNHFOPON_ != null) ? other.oNBKNHFOPON_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlaySettingInfoScNotify Clone()
	{
		return new SocialPlaySettingInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SocialPlaySettingInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SocialPlaySettingInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ONBKNHFOPON, other.ONBKNHFOPON))
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
		if (oNBKNHFOPON_ != null)
		{
			num ^= ONBKNHFOPON.GetHashCode();
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
		if (oNBKNHFOPON_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ONBKNHFOPON);
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
		if (oNBKNHFOPON_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ONBKNHFOPON);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SocialPlaySettingInfoScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oNBKNHFOPON_ != null)
		{
			if (oNBKNHFOPON_ == null)
			{
				ONBKNHFOPON = new NECGMCGFANN();
			}
			ONBKNHFOPON.MergeFrom(other.ONBKNHFOPON);
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
			if (oNBKNHFOPON_ == null)
			{
				ONBKNHFOPON = new NECGMCGFANN();
			}
			input.ReadMessage(ONBKNHFOPON);
		}
	}
}
