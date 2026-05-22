using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KKFANGIJAOF : IMessage<KKFANGIJAOF>, IMessage, IEquatable<KKFANGIJAOF>, IDeepCloneable<KKFANGIJAOF>, IBufferMessage
{
	private static readonly MessageParser<KKFANGIJAOF> _parser = new MessageParser<KKFANGIJAOF>(() => new KKFANGIJAOF());

	private UnknownFieldSet _unknownFields;

	public const int DPCBMJGBMGPFieldNumber = 13;

	private DECAOHONNJG dPCBMJGBMGP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KKFANGIJAOF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KKFANGIJAOFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DECAOHONNJG DPCBMJGBMGP
	{
		get
		{
			return dPCBMJGBMGP_;
		}
		set
		{
			dPCBMJGBMGP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKFANGIJAOF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKFANGIJAOF(KKFANGIJAOF other)
		: this()
	{
		dPCBMJGBMGP_ = ((other.dPCBMJGBMGP_ != null) ? other.dPCBMJGBMGP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKFANGIJAOF Clone()
	{
		return new KKFANGIJAOF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KKFANGIJAOF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KKFANGIJAOF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DPCBMJGBMGP, other.DPCBMJGBMGP))
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
		if (dPCBMJGBMGP_ != null)
		{
			num ^= DPCBMJGBMGP.GetHashCode();
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
		if (dPCBMJGBMGP_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(DPCBMJGBMGP);
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
		if (dPCBMJGBMGP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DPCBMJGBMGP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KKFANGIJAOF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dPCBMJGBMGP_ != null)
		{
			if (dPCBMJGBMGP_ == null)
			{
				DPCBMJGBMGP = new DECAOHONNJG();
			}
			DPCBMJGBMGP.MergeFrom(other.DPCBMJGBMGP);
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
			if (dPCBMJGBMGP_ == null)
			{
				DPCBMJGBMGP = new DECAOHONNJG();
			}
			input.ReadMessage(DPCBMJGBMGP);
		}
	}
}
