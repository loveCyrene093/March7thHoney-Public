using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CommonRogueUpdateScNotify : IMessage<CommonRogueUpdateScNotify>, IMessage, IEquatable<CommonRogueUpdateScNotify>, IDeepCloneable<CommonRogueUpdateScNotify>, IBufferMessage
{
	public enum KLBJNNJBOACOneofCase
	{
		None = 0,
		FCAPBPHLNCJ = 4,
		BLALLLNKHAC = 6,
		JNKMJMABPMP = 14
	}

	private static readonly MessageParser<CommonRogueUpdateScNotify> _parser = new MessageParser<CommonRogueUpdateScNotify>(() => new CommonRogueUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int FCAPBPHLNCJFieldNumber = 4;

	public const int BLALLLNKHACFieldNumber = 6;

	public const int JNKMJMABPMPFieldNumber = 14;

	private object kLBJNNJBOAC_;

	private KLBJNNJBOACOneofCase kLBJNNJBOACCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CommonRogueUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CommonRogueUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BFHNCFDGCLG FCAPBPHLNCJ
	{
		get
		{
			if (kLBJNNJBOACCase_ != KLBJNNJBOACOneofCase.FCAPBPHLNCJ)
			{
				return null;
			}
			return (BFHNCFDGCLG)kLBJNNJBOAC_;
		}
		set
		{
			kLBJNNJBOAC_ = value;
			kLBJNNJBOACCase_ = ((value != null) ? KLBJNNJBOACOneofCase.FCAPBPHLNCJ : KLBJNNJBOACOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFIKPFBPOMF BLALLLNKHAC
	{
		get
		{
			if (kLBJNNJBOACCase_ != KLBJNNJBOACOneofCase.BLALLLNKHAC)
			{
				return null;
			}
			return (NFIKPFBPOMF)kLBJNNJBOAC_;
		}
		set
		{
			kLBJNNJBOAC_ = value;
			kLBJNNJBOACCase_ = ((value != null) ? KLBJNNJBOACOneofCase.BLALLLNKHAC : KLBJNNJBOACOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LHOEMCHFOFA JNKMJMABPMP
	{
		get
		{
			if (kLBJNNJBOACCase_ != KLBJNNJBOACOneofCase.JNKMJMABPMP)
			{
				return null;
			}
			return (LHOEMCHFOFA)kLBJNNJBOAC_;
		}
		set
		{
			kLBJNNJBOAC_ = value;
			kLBJNNJBOACCase_ = ((value != null) ? KLBJNNJBOACOneofCase.JNKMJMABPMP : KLBJNNJBOACOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KLBJNNJBOACOneofCase KLBJNNJBOACCase => kLBJNNJBOACCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommonRogueUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommonRogueUpdateScNotify(CommonRogueUpdateScNotify other)
		: this()
	{
		switch (other.KLBJNNJBOACCase)
		{
		case KLBJNNJBOACOneofCase.FCAPBPHLNCJ:
			FCAPBPHLNCJ = other.FCAPBPHLNCJ.Clone();
			break;
		case KLBJNNJBOACOneofCase.BLALLLNKHAC:
			BLALLLNKHAC = other.BLALLLNKHAC.Clone();
			break;
		case KLBJNNJBOACOneofCase.JNKMJMABPMP:
			JNKMJMABPMP = other.JNKMJMABPMP.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CommonRogueUpdateScNotify Clone()
	{
		return new CommonRogueUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKLBJNNJBOAC()
	{
		kLBJNNJBOACCase_ = KLBJNNJBOACOneofCase.None;
		kLBJNNJBOAC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CommonRogueUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CommonRogueUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FCAPBPHLNCJ, other.FCAPBPHLNCJ))
		{
			return false;
		}
		if (!object.Equals(BLALLLNKHAC, other.BLALLLNKHAC))
		{
			return false;
		}
		if (!object.Equals(JNKMJMABPMP, other.JNKMJMABPMP))
		{
			return false;
		}
		if (KLBJNNJBOACCase != other.KLBJNNJBOACCase)
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
		if (kLBJNNJBOACCase_ == KLBJNNJBOACOneofCase.FCAPBPHLNCJ)
		{
			num ^= FCAPBPHLNCJ.GetHashCode();
		}
		if (kLBJNNJBOACCase_ == KLBJNNJBOACOneofCase.BLALLLNKHAC)
		{
			num ^= BLALLLNKHAC.GetHashCode();
		}
		if (kLBJNNJBOACCase_ == KLBJNNJBOACOneofCase.JNKMJMABPMP)
		{
			num ^= JNKMJMABPMP.GetHashCode();
		}
		num ^= (int)kLBJNNJBOACCase_;
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
		if (kLBJNNJBOACCase_ == KLBJNNJBOACOneofCase.FCAPBPHLNCJ)
		{
			output.WriteRawTag(34);
			output.WriteMessage(FCAPBPHLNCJ);
		}
		if (kLBJNNJBOACCase_ == KLBJNNJBOACOneofCase.BLALLLNKHAC)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BLALLLNKHAC);
		}
		if (kLBJNNJBOACCase_ == KLBJNNJBOACOneofCase.JNKMJMABPMP)
		{
			output.WriteRawTag(114);
			output.WriteMessage(JNKMJMABPMP);
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
		if (kLBJNNJBOACCase_ == KLBJNNJBOACOneofCase.FCAPBPHLNCJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FCAPBPHLNCJ);
		}
		if (kLBJNNJBOACCase_ == KLBJNNJBOACOneofCase.BLALLLNKHAC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BLALLLNKHAC);
		}
		if (kLBJNNJBOACCase_ == KLBJNNJBOACOneofCase.JNKMJMABPMP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JNKMJMABPMP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CommonRogueUpdateScNotify other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.KLBJNNJBOACCase)
		{
		case KLBJNNJBOACOneofCase.FCAPBPHLNCJ:
			if (FCAPBPHLNCJ == null)
			{
				FCAPBPHLNCJ = new BFHNCFDGCLG();
			}
			FCAPBPHLNCJ.MergeFrom(other.FCAPBPHLNCJ);
			break;
		case KLBJNNJBOACOneofCase.BLALLLNKHAC:
			if (BLALLLNKHAC == null)
			{
				BLALLLNKHAC = new NFIKPFBPOMF();
			}
			BLALLLNKHAC.MergeFrom(other.BLALLLNKHAC);
			break;
		case KLBJNNJBOACOneofCase.JNKMJMABPMP:
			if (JNKMJMABPMP == null)
			{
				JNKMJMABPMP = new LHOEMCHFOFA();
			}
			JNKMJMABPMP.MergeFrom(other.JNKMJMABPMP);
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
			case 34u:
			{
				BFHNCFDGCLG bFHNCFDGCLG = new BFHNCFDGCLG();
				if (kLBJNNJBOACCase_ == KLBJNNJBOACOneofCase.FCAPBPHLNCJ)
				{
					bFHNCFDGCLG.MergeFrom(FCAPBPHLNCJ);
				}
				input.ReadMessage(bFHNCFDGCLG);
				FCAPBPHLNCJ = bFHNCFDGCLG;
				break;
			}
			case 50u:
			{
				NFIKPFBPOMF nFIKPFBPOMF = new NFIKPFBPOMF();
				if (kLBJNNJBOACCase_ == KLBJNNJBOACOneofCase.BLALLLNKHAC)
				{
					nFIKPFBPOMF.MergeFrom(BLALLLNKHAC);
				}
				input.ReadMessage(nFIKPFBPOMF);
				BLALLLNKHAC = nFIKPFBPOMF;
				break;
			}
			case 114u:
			{
				LHOEMCHFOFA lHOEMCHFOFA = new LHOEMCHFOFA();
				if (kLBJNNJBOACCase_ == KLBJNNJBOACOneofCase.JNKMJMABPMP)
				{
					lHOEMCHFOFA.MergeFrom(JNKMJMABPMP);
				}
				input.ReadMessage(lHOEMCHFOFA);
				JNKMJMABPMP = lHOEMCHFOFA;
				break;
			}
			}
		}
	}
}
