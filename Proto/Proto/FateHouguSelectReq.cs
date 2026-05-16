using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FateHouguSelectReq : IMessage<FateHouguSelectReq>, IMessage, IEquatable<FateHouguSelectReq>, IDeepCloneable<FateHouguSelectReq>, IBufferMessage
{
	public enum IHNMHNPMHJGOneofCase
	{
		None = 0,
		CICGMNHMLME = 6,
		COHMGGPHIHN = 9
	}

	private static readonly MessageParser<FateHouguSelectReq> _parser = new MessageParser<FateHouguSelectReq>(() => new FateHouguSelectReq());

	private UnknownFieldSet _unknownFields;

	public const int QueuePositionFieldNumber = 12;

	private uint queuePosition_;

	public const int CICGMNHMLMEFieldNumber = 6;

	public const int COHMGGPHIHNFieldNumber = 9;

	private object iHNMHNPMHJG_;

	private IHNMHNPMHJGOneofCase iHNMHNPMHJGCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FateHouguSelectReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FateHouguSelectReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint QueuePosition
	{
		get
		{
			return queuePosition_;
		}
		set
		{
			queuePosition_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOJACNBCEEH CICGMNHMLME
	{
		get
		{
			if (iHNMHNPMHJGCase_ != IHNMHNPMHJGOneofCase.CICGMNHMLME)
			{
				return null;
			}
			return (DOJACNBCEEH)iHNMHNPMHJG_;
		}
		set
		{
			iHNMHNPMHJG_ = value;
			iHNMHNPMHJGCase_ = ((value != null) ? IHNMHNPMHJGOneofCase.CICGMNHMLME : IHNMHNPMHJGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOPNFPPIFCI COHMGGPHIHN
	{
		get
		{
			if (iHNMHNPMHJGCase_ != IHNMHNPMHJGOneofCase.COHMGGPHIHN)
			{
				return null;
			}
			return (KOPNFPPIFCI)iHNMHNPMHJG_;
		}
		set
		{
			iHNMHNPMHJG_ = value;
			iHNMHNPMHJGCase_ = ((value != null) ? IHNMHNPMHJGOneofCase.COHMGGPHIHN : IHNMHNPMHJGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHNMHNPMHJGOneofCase IHNMHNPMHJGCase => iHNMHNPMHJGCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateHouguSelectReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateHouguSelectReq(FateHouguSelectReq other)
		: this()
	{
		queuePosition_ = other.queuePosition_;
		switch (other.IHNMHNPMHJGCase)
		{
		case IHNMHNPMHJGOneofCase.CICGMNHMLME:
			CICGMNHMLME = other.CICGMNHMLME.Clone();
			break;
		case IHNMHNPMHJGOneofCase.COHMGGPHIHN:
			COHMGGPHIHN = other.COHMGGPHIHN.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateHouguSelectReq Clone()
	{
		return new FateHouguSelectReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearIHNMHNPMHJG()
	{
		iHNMHNPMHJGCase_ = IHNMHNPMHJGOneofCase.None;
		iHNMHNPMHJG_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FateHouguSelectReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FateHouguSelectReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (QueuePosition != other.QueuePosition)
		{
			return false;
		}
		if (!object.Equals(CICGMNHMLME, other.CICGMNHMLME))
		{
			return false;
		}
		if (!object.Equals(COHMGGPHIHN, other.COHMGGPHIHN))
		{
			return false;
		}
		if (IHNMHNPMHJGCase != other.IHNMHNPMHJGCase)
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
		if (QueuePosition != 0)
		{
			num ^= QueuePosition.GetHashCode();
		}
		if (iHNMHNPMHJGCase_ == IHNMHNPMHJGOneofCase.CICGMNHMLME)
		{
			num ^= CICGMNHMLME.GetHashCode();
		}
		if (iHNMHNPMHJGCase_ == IHNMHNPMHJGOneofCase.COHMGGPHIHN)
		{
			num ^= COHMGGPHIHN.GetHashCode();
		}
		num ^= (int)iHNMHNPMHJGCase_;
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
		if (iHNMHNPMHJGCase_ == IHNMHNPMHJGOneofCase.CICGMNHMLME)
		{
			output.WriteRawTag(50);
			output.WriteMessage(CICGMNHMLME);
		}
		if (iHNMHNPMHJGCase_ == IHNMHNPMHJGOneofCase.COHMGGPHIHN)
		{
			output.WriteRawTag(74);
			output.WriteMessage(COHMGGPHIHN);
		}
		if (QueuePosition != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(QueuePosition);
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
		if (QueuePosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QueuePosition);
		}
		if (iHNMHNPMHJGCase_ == IHNMHNPMHJGOneofCase.CICGMNHMLME)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CICGMNHMLME);
		}
		if (iHNMHNPMHJGCase_ == IHNMHNPMHJGOneofCase.COHMGGPHIHN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(COHMGGPHIHN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FateHouguSelectReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.QueuePosition != 0)
		{
			QueuePosition = other.QueuePosition;
		}
		switch (other.IHNMHNPMHJGCase)
		{
		case IHNMHNPMHJGOneofCase.CICGMNHMLME:
			if (CICGMNHMLME == null)
			{
				CICGMNHMLME = new DOJACNBCEEH();
			}
			CICGMNHMLME.MergeFrom(other.CICGMNHMLME);
			break;
		case IHNMHNPMHJGOneofCase.COHMGGPHIHN:
			if (COHMGGPHIHN == null)
			{
				COHMGGPHIHN = new KOPNFPPIFCI();
			}
			COHMGGPHIHN.MergeFrom(other.COHMGGPHIHN);
			break;
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
			case 50u:
			{
				DOJACNBCEEH dOJACNBCEEH = new DOJACNBCEEH();
				if (iHNMHNPMHJGCase_ == IHNMHNPMHJGOneofCase.CICGMNHMLME)
				{
					dOJACNBCEEH.MergeFrom(CICGMNHMLME);
				}
				input.ReadMessage(dOJACNBCEEH);
				CICGMNHMLME = dOJACNBCEEH;
				break;
			}
			case 74u:
			{
				KOPNFPPIFCI kOPNFPPIFCI = new KOPNFPPIFCI();
				if (iHNMHNPMHJGCase_ == IHNMHNPMHJGOneofCase.COHMGGPHIHN)
				{
					kOPNFPPIFCI.MergeFrom(COHMGGPHIHN);
				}
				input.ReadMessage(kOPNFPPIFCI);
				COHMGGPHIHN = kOPNFPPIFCI;
				break;
			}
			case 96u:
				QueuePosition = input.ReadUInt32();
				break;
			}
		}
	}
}
