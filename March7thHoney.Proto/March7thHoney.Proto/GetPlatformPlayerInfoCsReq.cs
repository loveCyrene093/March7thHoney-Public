using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetPlatformPlayerInfoCsReq : IMessage<GetPlatformPlayerInfoCsReq>, IMessage, IEquatable<GetPlatformPlayerInfoCsReq>, IDeepCloneable<GetPlatformPlayerInfoCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetPlatformPlayerInfoCsReq> _parser = new MessageParser<GetPlatformPlayerInfoCsReq>(() => new GetPlatformPlayerInfoCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PBHLHFPIACPFieldNumber = 1;

	private static readonly FieldCodec<string> _repeated_pBHLHFPIACP_codec = FieldCodec.ForString(10u);

	private readonly RepeatedField<string> pBHLHFPIACP_ = new RepeatedField<string>();

	public const int PlatformFieldNumber = 14;

	private PlatformType platform_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetPlatformPlayerInfoCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetPlatformPlayerInfoCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> PBHLHFPIACP => pBHLHFPIACP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlatformType Platform
	{
		get
		{
			return platform_;
		}
		set
		{
			platform_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPlatformPlayerInfoCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPlatformPlayerInfoCsReq(GetPlatformPlayerInfoCsReq other)
		: this()
	{
		pBHLHFPIACP_ = other.pBHLHFPIACP_.Clone();
		platform_ = other.platform_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPlatformPlayerInfoCsReq Clone()
	{
		return new GetPlatformPlayerInfoCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetPlatformPlayerInfoCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetPlatformPlayerInfoCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pBHLHFPIACP_.Equals(other.pBHLHFPIACP_))
		{
			return false;
		}
		if (Platform != other.Platform)
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
		num ^= pBHLHFPIACP_.GetHashCode();
		if (Platform != PlatformType.Editor)
		{
			num ^= Platform.GetHashCode();
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
		pBHLHFPIACP_.WriteTo(ref output, _repeated_pBHLHFPIACP_codec);
		if (Platform != PlatformType.Editor)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)Platform);
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
		num += pBHLHFPIACP_.CalculateSize(_repeated_pBHLHFPIACP_codec);
		if (Platform != PlatformType.Editor)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Platform);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetPlatformPlayerInfoCsReq other)
	{
		if (other != null)
		{
			pBHLHFPIACP_.Add(other.pBHLHFPIACP_);
			if (other.Platform != PlatformType.Editor)
			{
				Platform = other.Platform;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				pBHLHFPIACP_.AddEntriesFrom(ref input, _repeated_pBHLHFPIACP_codec);
				break;
			case 112u:
				Platform = (PlatformType)input.ReadEnum();
				break;
			}
		}
	}
}
