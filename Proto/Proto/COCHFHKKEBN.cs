using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class COCHFHKKEBN : IMessage<COCHFHKKEBN>, IMessage, IEquatable<COCHFHKKEBN>, IDeepCloneable<COCHFHKKEBN>, IBufferMessage
{
	private static readonly MessageParser<COCHFHKKEBN> _parser = new MessageParser<COCHFHKKEBN>(() => new COCHFHKKEBN());

	private UnknownFieldSet _unknownFields;

	public const int IMNOJIDJBNGFieldNumber = 7;

	private NHDKLMIMLKC iMNOJIDJBNG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<COCHFHKKEBN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => COCHFHKKEBNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHDKLMIMLKC IMNOJIDJBNG
	{
		get
		{
			return iMNOJIDJBNG_;
		}
		set
		{
			iMNOJIDJBNG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COCHFHKKEBN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COCHFHKKEBN(COCHFHKKEBN other)
		: this()
	{
		iMNOJIDJBNG_ = ((other.iMNOJIDJBNG_ != null) ? other.iMNOJIDJBNG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COCHFHKKEBN Clone()
	{
		return new COCHFHKKEBN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as COCHFHKKEBN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(COCHFHKKEBN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IMNOJIDJBNG, other.IMNOJIDJBNG))
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
		if (iMNOJIDJBNG_ != null)
		{
			num ^= IMNOJIDJBNG.GetHashCode();
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
		if (iMNOJIDJBNG_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(IMNOJIDJBNG);
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
		if (iMNOJIDJBNG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMNOJIDJBNG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(COCHFHKKEBN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iMNOJIDJBNG_ != null)
		{
			if (iMNOJIDJBNG_ == null)
			{
				IMNOJIDJBNG = new NHDKLMIMLKC();
			}
			IMNOJIDJBNG.MergeFrom(other.IMNOJIDJBNG);
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
			if (num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (iMNOJIDJBNG_ == null)
			{
				IMNOJIDJBNG = new NHDKLMIMLKC();
			}
			input.ReadMessage(IMNOJIDJBNG);
		}
	}
}
