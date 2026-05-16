using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetHipplenDataScRsp : IMessage<GetHipplenDataScRsp>, IMessage, IEquatable<GetHipplenDataScRsp>, IDeepCloneable<GetHipplenDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetHipplenDataScRsp> _parser = new MessageParser<GetHipplenDataScRsp>(() => new GetHipplenDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ACJHGLGHEAHFieldNumber = 1;

	private OOLHNFNKOHN aCJHGLGHEAH_;

	public const int CEAJNLLIBFPFieldNumber = 4;

	private LIOLPIJOMBI cEAJNLLIBFP_;

	public const int IPOEIGADLJNFieldNumber = 7;

	private uint iPOEIGADLJN_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int MPPJLFIDMLBFieldNumber = 10;

	private bool mPPJLFIDMLB_;

	public const int IBHLKGIEPLGFieldNumber = 14;

	private JFACONIBFHM iBHLKGIEPLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetHipplenDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetHipplenDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOLHNFNKOHN ACJHGLGHEAH
	{
		get
		{
			return aCJHGLGHEAH_;
		}
		set
		{
			aCJHGLGHEAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LIOLPIJOMBI CEAJNLLIBFP
	{
		get
		{
			return cEAJNLLIBFP_;
		}
		set
		{
			cEAJNLLIBFP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPOEIGADLJN
	{
		get
		{
			return iPOEIGADLJN_;
		}
		set
		{
			iPOEIGADLJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MPPJLFIDMLB
	{
		get
		{
			return mPPJLFIDMLB_;
		}
		set
		{
			mPPJLFIDMLB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFACONIBFHM IBHLKGIEPLG
	{
		get
		{
			return iBHLKGIEPLG_;
		}
		set
		{
			iBHLKGIEPLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetHipplenDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetHipplenDataScRsp(GetHipplenDataScRsp other)
		: this()
	{
		aCJHGLGHEAH_ = ((other.aCJHGLGHEAH_ != null) ? other.aCJHGLGHEAH_.Clone() : null);
		cEAJNLLIBFP_ = ((other.cEAJNLLIBFP_ != null) ? other.cEAJNLLIBFP_.Clone() : null);
		iPOEIGADLJN_ = other.iPOEIGADLJN_;
		retcode_ = other.retcode_;
		mPPJLFIDMLB_ = other.mPPJLFIDMLB_;
		iBHLKGIEPLG_ = ((other.iBHLKGIEPLG_ != null) ? other.iBHLKGIEPLG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetHipplenDataScRsp Clone()
	{
		return new GetHipplenDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetHipplenDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetHipplenDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ACJHGLGHEAH, other.ACJHGLGHEAH))
		{
			return false;
		}
		if (!object.Equals(CEAJNLLIBFP, other.CEAJNLLIBFP))
		{
			return false;
		}
		if (IPOEIGADLJN != other.IPOEIGADLJN)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (MPPJLFIDMLB != other.MPPJLFIDMLB)
		{
			return false;
		}
		if (!object.Equals(IBHLKGIEPLG, other.IBHLKGIEPLG))
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
		if (aCJHGLGHEAH_ != null)
		{
			num ^= ACJHGLGHEAH.GetHashCode();
		}
		if (cEAJNLLIBFP_ != null)
		{
			num ^= CEAJNLLIBFP.GetHashCode();
		}
		if (IPOEIGADLJN != 0)
		{
			num ^= IPOEIGADLJN.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (MPPJLFIDMLB)
		{
			num ^= MPPJLFIDMLB.GetHashCode();
		}
		if (iBHLKGIEPLG_ != null)
		{
			num ^= IBHLKGIEPLG.GetHashCode();
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
		if (aCJHGLGHEAH_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ACJHGLGHEAH);
		}
		if (cEAJNLLIBFP_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(CEAJNLLIBFP);
		}
		if (IPOEIGADLJN != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(IPOEIGADLJN);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (MPPJLFIDMLB)
		{
			output.WriteRawTag(80);
			output.WriteBool(MPPJLFIDMLB);
		}
		if (iBHLKGIEPLG_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(IBHLKGIEPLG);
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
		if (aCJHGLGHEAH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ACJHGLGHEAH);
		}
		if (cEAJNLLIBFP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CEAJNLLIBFP);
		}
		if (IPOEIGADLJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPOEIGADLJN);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (MPPJLFIDMLB)
		{
			num += 2;
		}
		if (iBHLKGIEPLG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IBHLKGIEPLG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetHipplenDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.aCJHGLGHEAH_ != null)
		{
			if (aCJHGLGHEAH_ == null)
			{
				ACJHGLGHEAH = new OOLHNFNKOHN();
			}
			ACJHGLGHEAH.MergeFrom(other.ACJHGLGHEAH);
		}
		if (other.cEAJNLLIBFP_ != null)
		{
			if (cEAJNLLIBFP_ == null)
			{
				CEAJNLLIBFP = new LIOLPIJOMBI();
			}
			CEAJNLLIBFP.MergeFrom(other.CEAJNLLIBFP);
		}
		if (other.IPOEIGADLJN != 0)
		{
			IPOEIGADLJN = other.IPOEIGADLJN;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.MPPJLFIDMLB)
		{
			MPPJLFIDMLB = other.MPPJLFIDMLB;
		}
		if (other.iBHLKGIEPLG_ != null)
		{
			if (iBHLKGIEPLG_ == null)
			{
				IBHLKGIEPLG = new JFACONIBFHM();
			}
			IBHLKGIEPLG.MergeFrom(other.IBHLKGIEPLG);
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
			case 10u:
				if (aCJHGLGHEAH_ == null)
				{
					ACJHGLGHEAH = new OOLHNFNKOHN();
				}
				input.ReadMessage(ACJHGLGHEAH);
				break;
			case 34u:
				if (cEAJNLLIBFP_ == null)
				{
					CEAJNLLIBFP = new LIOLPIJOMBI();
				}
				input.ReadMessage(CEAJNLLIBFP);
				break;
			case 56u:
				IPOEIGADLJN = input.ReadUInt32();
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 80u:
				MPPJLFIDMLB = input.ReadBool();
				break;
			case 114u:
				if (iBHLKGIEPLG_ == null)
				{
					IBHLKGIEPLG = new JFACONIBFHM();
				}
				input.ReadMessage(IBHLKGIEPLG);
				break;
			}
		}
	}
}
