using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainPartySettleNotify : IMessage<TrainPartySettleNotify>, IMessage, IEquatable<TrainPartySettleNotify>, IDeepCloneable<TrainPartySettleNotify>, IBufferMessage
{
	private static readonly MessageParser<TrainPartySettleNotify> _parser = new MessageParser<TrainPartySettleNotify>(() => new TrainPartySettleNotify());

	private UnknownFieldSet _unknownFields;

	public const int GDFPBHMMFEAFieldNumber = 5;

	private uint gDFPBHMMFEA_;

	public const int OFCKHGLINAGFieldNumber = 8;

	private MAGFKFCMLJM oFCKHGLINAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainPartySettleNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainPartySettleNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GDFPBHMMFEA
	{
		get
		{
			return gDFPBHMMFEA_;
		}
		set
		{
			gDFPBHMMFEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGFKFCMLJM OFCKHGLINAG
	{
		get
		{
			return oFCKHGLINAG_;
		}
		set
		{
			oFCKHGLINAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartySettleNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartySettleNotify(TrainPartySettleNotify other)
		: this()
	{
		gDFPBHMMFEA_ = other.gDFPBHMMFEA_;
		oFCKHGLINAG_ = ((other.oFCKHGLINAG_ != null) ? other.oFCKHGLINAG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainPartySettleNotify Clone()
	{
		return new TrainPartySettleNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainPartySettleNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainPartySettleNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GDFPBHMMFEA != other.GDFPBHMMFEA)
		{
			return false;
		}
		if (!object.Equals(OFCKHGLINAG, other.OFCKHGLINAG))
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
		if (GDFPBHMMFEA != 0)
		{
			num ^= GDFPBHMMFEA.GetHashCode();
		}
		if (oFCKHGLINAG_ != null)
		{
			num ^= OFCKHGLINAG.GetHashCode();
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
		if (GDFPBHMMFEA != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GDFPBHMMFEA);
		}
		if (oFCKHGLINAG_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(OFCKHGLINAG);
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
		if (GDFPBHMMFEA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GDFPBHMMFEA);
		}
		if (oFCKHGLINAG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OFCKHGLINAG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainPartySettleNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GDFPBHMMFEA != 0)
		{
			GDFPBHMMFEA = other.GDFPBHMMFEA;
		}
		if (other.oFCKHGLINAG_ != null)
		{
			if (oFCKHGLINAG_ == null)
			{
				OFCKHGLINAG = new MAGFKFCMLJM();
			}
			OFCKHGLINAG.MergeFrom(other.OFCKHGLINAG);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 40u:
				GDFPBHMMFEA = input.ReadUInt32();
				break;
			case 66u:
				if (oFCKHGLINAG_ == null)
				{
					OFCKHGLINAG = new MAGFKFCMLJM();
				}
				input.ReadMessage(OFCKHGLINAG);
				break;
			}
		}
	}
}
