using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDuelEndRoundBattleStageCsReq : IMessage<ChimeraDuelEndRoundBattleStageCsReq>, IMessage, IEquatable<ChimeraDuelEndRoundBattleStageCsReq>, IDeepCloneable<ChimeraDuelEndRoundBattleStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChimeraDuelEndRoundBattleStageCsReq> _parser = new MessageParser<ChimeraDuelEndRoundBattleStageCsReq>(() => new ChimeraDuelEndRoundBattleStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KGEBJNHOLCNFieldNumber = 7;

	private DCIFPICPJMK kGEBJNHOLCN_;

	public const int SttFieldNumber = 9;

	private HHBEDPMHNDK stt_;

	public const int NAIMOPOHJKPFieldNumber = 12;

	private uint nAIMOPOHJKP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDuelEndRoundBattleStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDuelEndRoundBattleStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DCIFPICPJMK KGEBJNHOLCN
	{
		get
		{
			return kGEBJNHOLCN_;
		}
		set
		{
			kGEBJNHOLCN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHBEDPMHNDK Stt
	{
		get
		{
			return stt_;
		}
		set
		{
			stt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NAIMOPOHJKP
	{
		get
		{
			return nAIMOPOHJKP_;
		}
		set
		{
			nAIMOPOHJKP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelEndRoundBattleStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelEndRoundBattleStageCsReq(ChimeraDuelEndRoundBattleStageCsReq other)
		: this()
	{
		kGEBJNHOLCN_ = other.kGEBJNHOLCN_;
		stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
		nAIMOPOHJKP_ = other.nAIMOPOHJKP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelEndRoundBattleStageCsReq Clone()
	{
		return new ChimeraDuelEndRoundBattleStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDuelEndRoundBattleStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDuelEndRoundBattleStageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KGEBJNHOLCN != other.KGEBJNHOLCN)
		{
			return false;
		}
		if (!object.Equals(Stt, other.Stt))
		{
			return false;
		}
		if (NAIMOPOHJKP != other.NAIMOPOHJKP)
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
		if (KGEBJNHOLCN != DCIFPICPJMK.Pcpdhelpkem)
		{
			num ^= KGEBJNHOLCN.GetHashCode();
		}
		if (stt_ != null)
		{
			num ^= Stt.GetHashCode();
		}
		if (NAIMOPOHJKP != 0)
		{
			num ^= NAIMOPOHJKP.GetHashCode();
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
		if (KGEBJNHOLCN != DCIFPICPJMK.Pcpdhelpkem)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)KGEBJNHOLCN);
		}
		if (stt_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Stt);
		}
		if (NAIMOPOHJKP != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NAIMOPOHJKP);
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
		if (KGEBJNHOLCN != DCIFPICPJMK.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)KGEBJNHOLCN);
		}
		if (stt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stt);
		}
		if (NAIMOPOHJKP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NAIMOPOHJKP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDuelEndRoundBattleStageCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.KGEBJNHOLCN != DCIFPICPJMK.Pcpdhelpkem)
		{
			KGEBJNHOLCN = other.KGEBJNHOLCN;
		}
		if (other.stt_ != null)
		{
			if (stt_ == null)
			{
				Stt = new HHBEDPMHNDK();
			}
			Stt.MergeFrom(other.Stt);
		}
		if (other.NAIMOPOHJKP != 0)
		{
			NAIMOPOHJKP = other.NAIMOPOHJKP;
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
			case 56u:
				KGEBJNHOLCN = (DCIFPICPJMK)input.ReadEnum();
				break;
			case 74u:
				if (stt_ == null)
				{
					Stt = new HHBEDPMHNDK();
				}
				input.ReadMessage(Stt);
				break;
			case 96u:
				NAIMOPOHJKP = input.ReadUInt32();
				break;
			}
		}
	}
}
